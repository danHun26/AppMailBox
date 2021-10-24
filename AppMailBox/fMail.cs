using EAGetMail;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fMail : Form
    {
        private int idPassLocal = 0;
        private int idDSMail = 0;
        private string savaLocal = "";
        private int tempCmbMail = 0;

        public fMail()
        {
            InitializeComponent();
        }

        //Nhận id mật khẩu local
        public fMail(int idPassLocal) : this()
        {
            this.idPassLocal = idPassLocal;
            this.tempCmbMail = this.idPassLocal;
        }

        //Nhận lại tên user trước đó
        public fMail(string cmbUserNameEmail, int idPassLocal) : this()
        {
            cmbEmail.Text = cmbUserNameEmail;
            this.idPassLocal = idPassLocal;
            this.tempCmbMail = this.idPassLocal;
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
                        if (item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true && item.id == this.idDSMail)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString())
                            {
                                this.idDSMail = 0;
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.NOIDUNG_MAIL.id, this.idPassLocal, 1);
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
            fAddEmail fAddMail = new fAddEmail(cmbEmail.Text, this.idPassLocal);
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
                                dtpMail.Value = item.THOIGIAN_GUI != null ? Convert.ToDateTime(item.THOIGIAN_GUI) : DateTime.Now;
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

                            //Xóa mail trên server
                            //oClient.Delete(info);

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
                                if (tempidContent1 < item.id)
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

                            //Xóa mail trên server
                            //oClient.Delete(info);

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
            else if (this.tempCmbMail == this.idPassLocal)
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        foreach (var item in db.MATKHAU_MAILs.ToList())
                        {
                            if (item.FK_id_MATKHAU_LOCAL == this.idPassLocal)
                            {
                                cmbEmail.Items.Add(item.USERNAME_MAIL);
                                cmbEmail.Text = item.USERNAME_MAIL;
                            }
                        }
                    }
                    this.tempCmbMail = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvListMail.Rows.Clear();
                btnDeleteAll.Enabled = false;
                btnRecovery.Enabled = false;
                btnReplyMail.Enabled = true;
                btnBack.Enabled = false;

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
                                //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            btnRecovery.Enabled = false;
            btnReplyMail.Enabled = true;
            btnBack.Enabled = false;
            this.savaLocal = "Inbox";

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
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            this.savaLocal = "Inbox";
            dgvListMail.Rows.Clear();
            fMail_Load(sender, e);
        }

        //Sự kiện thư đi
        private void btnOutbox_Click(object sender, EventArgs e)
        {
            btnDeleteAll.Enabled = false;
            btnRecovery.Enabled = false;
            btnReplyMail.Enabled = false;
            btnBack.Enabled = false;
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
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            btnRecovery.Enabled = false;
            btnReplyMail.Enabled = false;
            btnBack.Enabled = false;
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
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            btnRecovery.Enabled = false;
            btnReplyMail.Enabled = false;
            btnBack.Enabled = true;
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
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            btnRecovery.Enabled = false;
            btnReplyMail.Enabled = false;
            btnBack.Enabled = false;
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
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            btnRecovery.Enabled = true;
            btnReplyMail.Enabled = false;
            btnBack.Enabled = false;
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
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == true)
                        {
                            int index = dgvListMail.Rows.Add();
                            dgvListMail.Rows[index].Cells[0].Value = item.id;
                            dgvListMail.Rows[index].Cells[1].Value = item.NOIDUNG_MAIL.TO_MAIL;
                            dgvListMail.Rows[index].Cells[2].Value = item.NOIDUNG_MAIL.SUBJECT_MAIL;
                            //dgvListMail.Rows[index].Cells[3].Value = item.NOIDUNG_MAIL.CONTENT_MAIL;
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
            try
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        TRANG_THAI statusMail = new TRANG_THAI();
                        int temp = 0;
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (item.id == this.idDSMail && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false)
                            {
                                statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                                statusMail.XOATHU = true;
                                statusMail.DANHDAU = false;
                                db.SubmitChanges();
                                loadLocalButton(sender, e);
                                temp = 0;
                                this.idDSMail = 0;
                                break;
                            }
                            else if (item.id == this.idDSMail && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == true) temp = 1;
                        }
                        if (temp == 1)
                        {
                            throw new Exception("Thư này đã được xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện đánh dấu thư
        private void btnArchiveMail_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        TRANG_THAI statusMail = new TRANG_THAI();

                        int temp = 0;
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (item.id == this.idDSMail
                                && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == false
                                && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                            {
                                statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                                statusMail.DANHDAU = true;
                                db.SubmitChanges();
                                loadLocalButton(sender, e);
                                temp = 0;
                                this.idDSMail = 0;
                                break;
                            }
                            if (item.id == this.idDSMail
                                && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == true)
                            {
                                temp = 1;
                                break;
                            }
                            if (item.id == this.idDSMail
                                && item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true)
                            {
                                temp = 2;
                                break;
                            }
                            if (item.id == this.idDSMail
                                && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == true)
                            {
                                temp = 3;
                                break;
                            }
                        }
                        if (temp == 1)
                            throw new Exception("Không được phép đánh dấu thư đã xóa");
                        else if (temp == 2)
                            throw new Exception("Không được phép đánh dấu thư nháp");
                        else if (temp == 3)
                            throw new Exception("Thư này đã được đánh đấu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện hoàn nguên
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.savaLocal == "Starred")
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        TRANG_THAI statusMail = new TRANG_THAI();
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (item.id == this.idDSMail
                                && item.NOIDUNG_MAIL.TRANG_THAI.DANHDAU == true)
                            {
                                this.idDSMail = 0;
                                statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                                statusMail.DANHDAU = false;
                                db.SubmitChanges();
                                loadLocalButton(sender, e);
                                break;
                            }
                        }
                        loadLocalButton(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Revert starred chỉ hỗ trợ cho thư đánh dấu sao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Sự kiện trả lời mail
        private void btnReplyMail_Click(object sender, EventArgs e)
        {
            if (this.savaLocal == "Inbox")
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        foreach (var item in db.DANHSACH_MAILs.ToList())
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString() && item.id == this.idDSMail)
                            {
                                this.idDSMail = 0;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.NOIDUNG_MAIL.id, this.idPassLocal, 2);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                                break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Reply mail chỉ hỗ trợ cho thư gửi đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        //Khôi phục Mail đã xóa
        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    TRANG_THAI statusMail = new TRANG_THAI();
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if (item.id == this.idDSMail
                            && item.NOIDUNG_MAIL.TRANG_THAI.XOATHU == true)
                        {
                            this.idDSMail = 0;
                            statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                            statusMail.XOATHU = false;
                            db.SubmitChanges();
                            loadLocalButton(sender, e);
                            break;
                        }
                    }
                    btnGarbageCan_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện đăng xuất
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.idPassLocal = 0;
            fMail_Load(sender, e);
        }

        //Sự kiện tắt MailBox
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
                this.Close();
        }

        //Hiện thông tin cả nhóm
        private void btnContact_Click(object sender, EventArgs e)
        {
            string content =
                "Thông tin liên lạc nhóm phát triển MailBox" + System.Environment.NewLine +
                "   Thành viên 1: (Nhóm trưởng)" + System.Environment.NewLine +
                "\tHọ và tên: Đào Minh Huân" + System.Environment.NewLine +
                "\tMSSV: 1811770039" + System.Environment.NewLine +
                "\tLớp: 18DATA1" + System.Environment.NewLine +
                "   Thành viên 2:" + System.Environment.NewLine +
                "\tHọ và tên: Trần Văn Phương Nam" + System.Environment.NewLine +
                "\tMSSV: 1811770076" + System.Environment.NewLine +
                "\tLớp: 18DATA1" + System.Environment.NewLine +
                "   Thành viên 3:" + System.Environment.NewLine +
                "\tHọ và tên: Trần Hữu Toàn" + System.Environment.NewLine +
                "\tMSSV: 1811770093" + System.Environment.NewLine +
                "\tLớp: 18DATA1" + System.Environment.NewLine +
                "   Thành viên 4:" + System.Environment.NewLine +
                "\tHọ và tên: Nguyễn Quang Khang" + System.Environment.NewLine +
                "\tMSSV: 1811770017" + System.Environment.NewLine +
                "\tLớp: 18DATA1";
            MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Sự kiện About
        private void btnVersion_Click(object sender, EventArgs e)
        {
            fAbout fSM = new fAbout(cmbEmail.Text, this.idPassLocal);
            this.Hide();
            fSM.ShowDialog();
            this.Close();
        }

        //Sự kiện Feedback
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                string Email_Local = "";
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.THONGTIN_CLIENTs.ToList())
                    {
                        if (this.idPassLocal == item.FK_id_MATKHAU_LOCAL)
                        {
                            Email_Local = item.EMAIL;
                        }
                    }
                    foreach (var item in db.MATKHAU_MAILs.ToList())
                    {
                        if (cmbEmail.Text == item.USERNAME_MAIL)
                        {
                            fFeedback fSM = new fFeedback(item.USERNAME_MAIL, item.PASSWORD_MAIL, 
                                this.idPassLocal, item.DOMAIN_MAIL.DOMAIN, item.DOMAIN_MAIL.PORT_MAIL, Email_Local);
                            this.Hide();
                            fSM.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện xem thông tin cá nhân
        private void btnEdit_Click(object sender, EventArgs e)
        {
            fMyAccount fSM = new fMyAccount(cmbEmail.Text, this.idPassLocal);
            this.Hide();
            fSM.ShowDialog();
            this.Close();
        }

        //Delete All
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    TRANG_THAI statusMail = new TRANG_THAI();
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        if(this.idDSMail == item.id)
                        {
                            statusMail = db.TRANG_THAIs.Where(s => s.id == item.NOIDUNG_MAIL.TRANG_THAI.id).Single();
                        }
                    }
                    
                    DialogResult check = MessageBox.Show("Thư này sẽ được xóa vĩnh viễn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (check == DialogResult.Yes)
                    {
                        db.TRANG_THAIs.DeleteOnSubmit(statusMail);
                        db.SubmitChanges();
                        MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnGarbageCan_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ Admin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
