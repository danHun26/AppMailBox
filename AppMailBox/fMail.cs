﻿using EAGetMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Net;

namespace AppMailBox
{
    public partial class fMail : Form
    {
        private int idPassLocal = 0;
        private int idDSMail = 0;
        private string savaLocal = "";

        public fMail()
        {
            InitializeComponent();
        }

        //Nhận id mật khẩu local [AddMail]
        public fMail(int idPassLocal) : this()
        {
            this.idPassLocal = idPassLocal;
        }

        //Nhận lại tên user trước đó [SendMail]
        public fMail(string cmbUserNameEmail, int idPassLocal) : this()
        {
            cmbEmail.Text = cmbUserNameEmail;
            this.idPassLocal = idPassLocal;
        }

        //Sự kiện chọn combobox để gửi mail mới
        private void btnNewMail_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    int temp = 0;
                    //Lấy thông tin thư nháp
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        //Mail nháp
                        if (item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true && item.NOIDUNG_MAIL.id == this.idDSMail)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString())
                            {
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.MATKHAU_MAIL.id, item.NOIDUNG_MAIL.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                                break;
                            }
                        }
                    }
                    //Gửi mail mới
                    if (temp == 0)
                    {
                        foreach (var item in db.MATKHAU_MAILs.ToList())
                        {
                            if (cmbEmail.Text == item.USERNAME_MAIL.ToString())
                            {
                                fSendMail fsm = new fSendMail(item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL,
                                                            item.USERNAME_MAIL, item.PASSWORD_MAIL, item.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thêm 1 địa chi email mới
        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            fAddEmail fAddMail = new fAddEmail(this.idPassLocal);
            this.Hide();
            fAddMail.ShowDialog();
            this.Close();
        }

        //Click chọn mail cần đọc
        private void dgvListMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvListMail.Rows.Count - 1)
                {
                    DataGridViewRow row = dgvListMail.Rows[e.RowIndex];
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (item.id.ToString() == row.Cells[0].Value.ToString())
                            {
                                this.idDSMail = item.id;
                                string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory()); 
                                wbMail.Navigate(new System.Uri($"{localData}\\{item.NOIDUNG_MAIL.CONTENT_MAIL}"));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Encoding GetUTF8()
        {
            return Encoding.UTF8;
        }

        //Hàm tải thư xuống
        private void DownloadMailBox(string userNameEmail, string passEmail)
        {
            try
            {
                int tempSyns = 0;
                string fileNameCheck = "";
                string checkMailServer = "";
                string localDataCheck = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                int countAddMail = 0;

                MailServer oServer = new MailServer("imap.gmail.com", userNameEmail, passEmail, ServerProtocol.Imap4);
                oServer.SSLConnection = true;
                oServer.Port = 993;

                MailClient oClient = new MailClient("TryIt");
                oClient.Connect(oServer);

                MailInfo[] infos = oClient.GetMailInfos();
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];
                    Mail oMail = oClient.GetMail(info);
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        DANHSACH_MAIL listMail = new DANHSACH_MAIL();
                        TRANG_THAI statusMail = new TRANG_THAI();
                        NOIDUNG_MAIL contentMail = new NOIDUNG_MAIL();
                        WebClient client = new WebClient();
                        
                        checkMailServer = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>" + System.Environment.NewLine + oMail.HtmlBody.ToString();

                        foreach (var item in db.NOIDUNG_MAILs.ToList())
                        {
                            fileNameCheck = File.ReadAllText($"{localDataCheck}\\{item.CONTENT_MAIL}", Encoding.UTF8);
                            if (fileNameCheck == checkMailServer)
                            {
                                tempSyns = 2;
                                break;
                            }
                            else
                            {
                                tempSyns = 1;
                            }
                        }
                        if (tempSyns == 0)
                        {
                            //insert trạng thái mail
                            statusMail.DANHDAU = false;
                            statusMail.XOATHU = false;
                            statusMail.STATUS_MAIL = false;
                            statusMail.SEND_RECEIVE = true;
                            statusMail.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                            db.TRANG_THAIs.InsertOnSubmit(statusMail);
                            db.SubmitChanges();

                            //insert nội dung mail
                            contentMail.TO_MAIL = oMail.From.ToString();
                            contentMail.FROM_MAIL = cmbEmail.Text.ToString();
                            contentMail.SUBJECT_MAIL = oMail.Subject.ToString();

                            //contentMail.CONTENT_MAIL = oMail.HtmlBody.ToString();
                            //Tạo nơi chứa
                            string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                            if (!Directory.Exists(localData))
                            {
                                Directory.CreateDirectory(localData);
                            }
                            string contentMailHtml = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>" + System.Environment.NewLine + oMail.HtmlBody.ToString();
                            File.WriteAllText($"{localData}\\1.html", contentMailHtml);

                            contentMail.PATH_ATTACH = null;
                            int tempidTT = 0;
                            foreach (var item in db.TRANG_THAIs.ToList())
                            {
                                if (tempidTT < item.id)
                                {
                                    tempidTT = item.id;
                                }
                                contentMail.FK_id_TRANG_THAI = tempidTT;
                            }
                            db.NOIDUNG_MAILs.InsertOnSubmit(contentMail);
                            db.SubmitChanges();

                            //insert danh sach mail
                            listMail.THOIGIAN_GUI = null;
                            foreach (var item in db.MATKHAU_MAILs.ToList())
                            {
                                if (cmbEmail.Text == item.USERNAME_MAIL)
                                {
                                    listMail.FK_id_MATKHAU_MAIL = item.id;
                                }
                            }
                            int tempidContent2 = 0;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if (tempidContent2 < item.id)
                                {
                                    tempidContent2 = item.id;
                                }
                                listMail.FK_id_NOIDUNG_MAIL = tempidContent2;
                            }
                            db.DANHSACH_MAILs.InsertOnSubmit(listMail);
                            db.SubmitChanges();

                            countAddMail++;
                        }
                        else if (tempSyns == 1)
                        {
                            //insert trạng thái mail
                            statusMail.DANHDAU = false;
                            statusMail.XOATHU = false;
                            statusMail.STATUS_MAIL = false;
                            statusMail.SEND_RECEIVE = true;
                            statusMail.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                            db.TRANG_THAIs.InsertOnSubmit(statusMail);
                            db.SubmitChanges();

                            //insert nội dung mail
                            contentMail.TO_MAIL = oMail.From.ToString();
                            contentMail.FROM_MAIL = cmbEmail.Text.ToString();
                            contentMail.SUBJECT_MAIL = oMail.Subject.ToString();

                            int tempidContent1 = 0;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if(tempidContent1 < item.id)
                                {
                                    tempidContent1 = item.id;
                                }
                            }
                            tempidContent1++;
                            //Tạo nơi chứa
                            string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                            if (!Directory.Exists(localData))
                            {
                                Directory.CreateDirectory(localData);
                            }
                            string contentMailHtml = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>" + System.Environment.NewLine + oMail.HtmlBody.ToString();
                            string filename = tempidContent1.ToString() + ".html";
                            File.WriteAllText($"{localData}\\{filename}", contentMailHtml);

                            contentMail.PATH_ATTACH = null;
                            int tempidTT = 0;
                            foreach (var item in db.TRANG_THAIs.ToList())
                            {
                                if (tempidTT < item.id)
                                {
                                    tempidTT = item.id;
                                }
                                contentMail.FK_id_TRANG_THAI = tempidTT;
                            }
               
                            db.NOIDUNG_MAILs.InsertOnSubmit(contentMail);
                            db.SubmitChanges();

                            //insert danh sach mail
                            listMail.THOIGIAN_GUI = null;
                            foreach (var item in db.MATKHAU_MAILs.ToList())
                            {
                                if (cmbEmail.Text == item.USERNAME_MAIL)
                                {
                                    listMail.FK_id_MATKHAU_MAIL = item.id;
                                }
                            }
                            int tempidContent2 = 0;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if (tempidContent2 < item.id)
                                {
                                    tempidContent2 = item.id;
                                }
                                listMail.FK_id_NOIDUNG_MAIL = tempidContent2;
                            }
                            db.DANHSACH_MAILs.InsertOnSubmit(listMail);
                            db.SubmitChanges();

                            tempSyns = 1;
                            countAddMail++;
                        }
                    }
                }
                oClient.Quit();
                MessageBox.Show($"Đồng bộ thêm {countAddMail} email mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện load form
        private void fMail_Load(object sender, EventArgs e)
        {
            if (this.idPassLocal == 0)
            {
                fDangNhap fLogin = new fDangNhap();
                this.Hide();
                fLogin.ShowDialog();
                this.Close();
            }
            else
            {
                dgvListMail.Rows.Clear();
                btnDeleteAll.Enabled = false;

                btnInbox.BackColor = Color.LimeGreen;
                btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
                btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
                btnStarred.BackColor = Color.FromArgb(238, 26, 74);
                btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
                btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

                btnInbox.FlatStyle = FlatStyle.Standard;
                btnOutbox.FlatStyle = FlatStyle.Popup;
                btnAllMail.FlatStyle = FlatStyle.Popup;
                btnStarred.FlatStyle = FlatStyle.Popup;
                btnDrafts.FlatStyle = FlatStyle.Popup;
                btnGarbageCan.FlatStyle = FlatStyle.Popup;

                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                                && item.NOIDUNG_MAIL.TRANG_THAI.SEND_RECEIVE == true
                                && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                                && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false
                                && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                            {
                                int index = dgvListMail.Rows.Add();
                                dgvListMail.Rows[index].Cells[0].Value = item.id;
                                dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                                dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                                dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                            }
                        }
                        this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                    }
                    int countMail = dgvListMail.Rows.Count - 1;
                    lTotal.Text = "Total: " + countMail.ToString() + " email.";
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Chọn tài khoản email
        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;

            btnInbox.BackColor = Color.LimeGreen;
            btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
            btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
            btnStarred.BackColor = Color.FromArgb(238, 26, 74);
            btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
            btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

            btnInbox.FlatStyle = FlatStyle.Standard;
            btnOutbox.FlatStyle = FlatStyle.Popup;
            btnAllMail.FlatStyle = FlatStyle.Popup;
            btnStarred.FlatStyle = FlatStyle.Popup;
            btnDrafts.FlatStyle = FlatStyle.Popup;
            btnGarbageCan.FlatStyle = FlatStyle.Popup;

            dgvListMail.Rows.Clear();
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                            && item.NOIDUNG_MAIL.TRANG_THAI.SEND_RECEIVE == true
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                    this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                }

                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        //Sự kiện đồng bộ mail từ server xuống
        private void btnSendReceive_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.MATKHAU_MAILs.ToList())
                    {
                        if (item.USERNAME_MAIL == cmbEmail.Text)
                        {
                            DownloadMailBox(item.USERNAME_MAIL,
                                Eramake.eCryptography.Decrypt(item.PASSWORD_MAIL));
                            break;
                        }
                    }
                }
                fMail_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Sự kiện thư đến 
        private void btnInbox_Click(object sender, EventArgs e)
        {
            dgvListMail.Rows.Clear();
            fMail_Load(sender, e);
            this.savaLocal = "Inbox";
        }

        //Sự kiện thư đi
        private void btnOutbox_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;
            this.savaLocal = "Outbox";

            btnInbox.BackColor = Color.FromArgb(238, 26, 74);
            btnOutbox.BackColor = Color.LimeGreen;
            btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
            btnStarred.BackColor = Color.FromArgb(238, 26, 74);
            btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
            btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

            btnInbox.FlatStyle = FlatStyle.Popup;
            btnOutbox.FlatStyle = FlatStyle.Standard;
            btnAllMail.FlatStyle = FlatStyle.Popup;
            btnStarred.FlatStyle = FlatStyle.Popup;
            btnDrafts.FlatStyle = FlatStyle.Popup;
            btnGarbageCan.FlatStyle = FlatStyle.Popup;

            dgvListMail.Rows.Clear();

            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                            && item.NOIDUNG_MAIL.TRANG_THAI.SEND_RECEIVE == false 
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                }
                this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Show tất cả mail trong database
        private void btnAllMail_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;
            this.savaLocal = "AllMail";

            btnInbox.BackColor = Color.FromArgb(238, 26, 74);
            btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
            btnAllMail.BackColor = Color.LimeGreen;
            btnStarred.BackColor = Color.FromArgb(238, 26, 74);
            btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
            btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

            btnInbox.FlatStyle = FlatStyle.Popup;
            btnOutbox.FlatStyle = FlatStyle.Popup;
            btnAllMail.FlatStyle = FlatStyle.Standard;
            btnStarred.FlatStyle = FlatStyle.Popup;
            btnDrafts.FlatStyle = FlatStyle.Popup;
            btnGarbageCan.FlatStyle = FlatStyle.Popup;

            dgvListMail.Rows.Clear();

            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                }
                this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện thư đánh dấu
        private void btnStarred_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;
            this.savaLocal = "Starred";

            btnInbox.BackColor = Color.FromArgb(238, 26, 74);
            btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
            btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
            btnStarred.BackColor = Color.LimeGreen;
            btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
            btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

            btnInbox.FlatStyle = FlatStyle.Popup;
            btnOutbox.FlatStyle = FlatStyle.Popup;
            btnAllMail.FlatStyle = FlatStyle.Popup;
            btnStarred.FlatStyle = FlatStyle.Standard;
            btnDrafts.FlatStyle = FlatStyle.Popup;
            btnGarbageCan.FlatStyle = FlatStyle.Popup;

            dgvListMail.Rows.Clear();

            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == true
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                }
                this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện load thư nháp
        private void btnDrafts_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;
            this.savaLocal = "Drafts";

            btnInbox.BackColor = Color.FromArgb(238, 26, 74);
            btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
            btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
            btnStarred.BackColor = Color.FromArgb(238, 26, 74);
            btnDrafts.BackColor = Color.LimeGreen;
            btnGarbageCan.BackColor = Color.FromArgb(238, 26, 74);

            btnInbox.FlatStyle = FlatStyle.Popup;
            btnOutbox.FlatStyle = FlatStyle.Popup;
            btnAllMail.FlatStyle = FlatStyle.Popup;
            btnStarred.FlatStyle = FlatStyle.Popup;
            btnDrafts.FlatStyle = FlatStyle.Standard;
            btnGarbageCan.FlatStyle = FlatStyle.Popup;

            dgvListMail.Rows.Clear();

            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true
                            && item.NOIDUNG_MAIL.TRANG_THAI.SEND_RECEIVE == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                }
                this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện thư đã xóa
        private void btnGarbageCan_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = true;
            this.savaLocal = "GarbageCan";

            btnInbox.BackColor = Color.FromArgb(238, 26, 74);
            btnOutbox.BackColor = Color.FromArgb(238, 26, 74);
            btnAllMail.BackColor = Color.FromArgb(238, 26, 74);
            btnStarred.BackColor = Color.FromArgb(238, 26, 74);
            btnDrafts.BackColor = Color.FromArgb(238, 26, 74);
            btnGarbageCan.BackColor = Color.LimeGreen;

            btnInbox.FlatStyle = FlatStyle.Popup;
            btnOutbox.FlatStyle = FlatStyle.Popup;
            btnAllMail.FlatStyle = FlatStyle.Popup;
            btnStarred.FlatStyle = FlatStyle.Popup;
            btnDrafts.FlatStyle = FlatStyle.Popup;
            btnGarbageCan.FlatStyle = FlatStyle.Standard;

            dgvListMail.Rows.Clear();

            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.NOIDUNG_MAIL.FROM_MAIL.ToString() == cmbEmail.Text 
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == true
                            && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false
                            && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == false)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
                        }
                    }
                }
                this.dgvListMail.Sort(this.dgvListMail.Columns[0], ListSortDirection.Descending);
                int countMail = dgvListMail.Rows.Count - 1;
                lTotal.Text = "Total: " + countMail.ToString() + " email.";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện lưu lại vị trị
        private void loadLocalButton(object sender, EventArgs e)
        {
            if (this.savaLocal == "Inbox")
            {
                btnInbox_Click(sender, e);
            }
            else if (this.savaLocal == "Outbox")
            {
                btnOutbox_Click(sender, e);
            }
            else if (this.savaLocal == "AllMail")
            {
                btnAllMail_Click(sender, e);
            }
            else if (this.savaLocal == "Starred")
            {
                btnStarred_Click(sender, e);
            }
            else if (this.savaLocal == "Drafts")
            {
                btnDrafts_Click(sender, e);
            }
        }

        //Cập nhật sự kiện xóa
        private void btnDeleteMail_Click(object sender, EventArgs e)
        {
            using (dbMailBoxDataContext db = new dbMailBoxDataContext())
            {
                TRANG_THAI statusMail = new TRANG_THAI();

                foreach (var item in db.DANHSACH_MAILs.ToList())
                {
                    if (item.id == this.idDSMail)
                    {
                        statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                        statusMail.XOATHU = true;
                        statusMail.DANHDAU = false;
                        db.SubmitChanges();
                    }
                }
            }
            loadLocalButton(sender, e);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }
    }
}
