using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fSendMail : Form
    {
        private string serverMail = "";
        private int portServerMail = 0;
        private string userMailAcc = "";
        private string passMailAcc = "";
        private int idpassMail = 0;
        private int idTempMail = 0;
        private int classifyMail = 0;
        private int idPassLocal = 0;
        private string tempSub = "(Không có tiêu đề)";

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Constructor mặc định
        public fSendMail()
        {
            InitializeComponent();
        }

        //Constructor có tham số cho mail mới
        public fSendMail(string serverMail, int portServerMail, string userMailAcc,
            string passMailAcc, int idpassMail, int idPassLocal) : this()
        {
            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.userMailAcc = userMailAcc;
            this.passMailAcc = Eramake.eCryptography.Decrypt(passMailAcc);
            this.idpassMail = idpassMail;
            this.idPassLocal = idPassLocal;
        }

        ////Constructor có tham số mở mail nháp
        public fSendMail(string serverMail, int portServerMail, string userMailAcc,
            string passMailAcc, int idTempMail, int idPassLocal, int classifyMail) : this()
        {
            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.userMailAcc = userMailAcc;
            this.passMailAcc = Eramake.eCryptography.Decrypt(passMailAcc);
            this.idTempMail = idTempMail;
            this.idPassLocal = idPassLocal;
            this.classifyMail = classifyMail;
        }

        //bấm nút gửi thư
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                    if (Regex.IsMatch(txtToMail.Text, pattern) == false)
                        throw new Exception("Định dạng email gửi không đúng.");

                    if (txtSubjectMail.Text != "")
                    {
                        tempSub = txtSubjectMail.Text;
                    }
                    MailMessage mail = new MailMessage(this.userMailAcc, txtToMail.Text.ToLower(), tempSub, rTxtContent.Text);
                    mail.IsBodyHtml = true;
                    if (File.Exists(txtPathAttach.Text))
                    {
                        Attachment fAttach = new Attachment(txtPathAttach.Text);
                        mail.Attachments.Add(fAttach);
                    }

                    SmtpClient client = new SmtpClient(this.serverMail);
                    client.UseDefaultCredentials = false;
                    client.Port = this.portServerMail;
                    client.Credentials = new System.Net.NetworkCredential(this.userMailAcc, this.passMailAcc);
                    client.EnableSsl = true;
                    try
                    {
                        client.Send(mail);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Gửi mail thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Gửi mail thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Gửi mail mới
                    if (this.classifyMail == 0)
                    {
                        //Lưu vào database
                        using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                        {
                            int tempIDNDMail = 0;
                            int tempIDStatus = 0;

                            DANHSACH_MAIL dsMail = new DANHSACH_MAIL();
                            NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                            TRANG_THAI status = new TRANG_THAI();

                            //TRẠNG THÁI
                            status.DANHDAU = false;
                            status.XOATHU = false;
                            status.STATUS_MAIL = false;
                            status.SEND_RECEIVE = false;
                            status.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                            db.TRANG_THAIs.InsertOnSubmit(status);
                            db.SubmitChanges();

                            //NỘI DUNG MAIL
                            ndMail.FROM_MAIL = txtFromMail.Text.ToLower();
                            ndMail.TO_MAIL = txtToMail.Text.ToLower();
                            ndMail.SUBJECT_MAIL = tempSub;

                            int tempidContent = 0;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if (tempidContent < item.id)
                                {
                                    tempidContent = item.id;
                                }
                            }
                            tempidContent++;
                            //Tạo nơi chứa
                            string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                            if (!Directory.Exists(localData))
                            {
                                Directory.CreateDirectory(localData);
                            }
                            string contentMailHtml = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>"
                                + System.Environment.NewLine
                                + System.Environment.NewLine
                                + rTxtContent.Text;
                            string filename = tempidContent.ToString() + ".html";
                            File.WriteAllText($"{localData}\\{filename}", contentMailHtml);

                            ndMail.PATH_ATTACH = txtPathAttach.Text;
                            foreach (var item in db.TRANG_THAIs.ToList())
                            {
                                if (tempIDStatus < item.id)
                                    tempIDStatus = item.id;
                                ndMail.FK_id_TRANG_THAI = tempIDStatus;
                            }
                            db.NOIDUNG_MAILs.InsertOnSubmit(ndMail);
                            db.SubmitChanges();

                            //DANH SÁCH MAIL
                            dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                            dsMail.FK_id_MATKHAU_MAIL = this.idpassMail;
                            foreach (var item in db.NOIDUNG_MAILs.ToList())
                            {
                                if (tempIDNDMail < item.id)
                                    tempIDNDMail = item.id;
                                dsMail.FK_id_NOIDUNG_MAIL = tempIDNDMail;
                            }
                            db.DANHSACH_MAILs.InsertOnSubmit(dsMail);
                            db.SubmitChanges();
                        }
                    }
                    //Gửi mail nháp
                    else
                    {
                        using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                        {
                            NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                            DANHSACH_MAIL dsMail = new DANHSACH_MAIL();

                            ndMail = db.NOIDUNG_MAILs.Where(s => s.id == this.idTempMail).Single();
                            dsMail = db.DANHSACH_MAILs.Where(s => s.FK_id_NOIDUNG_MAIL == this.idTempMail).Single();

                            ndMail.TRANG_THAI.STATUS_MAIL = false;
                            ndMail.TRANG_THAI.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                            dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                            ndMail.TO_MAIL = txtToMail.Text.ToLower();
                            ndMail.SUBJECT_MAIL = tempSub;
                            //Tạo nơi chứa
                            string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                            if (!Directory.Exists(localData))
                            {
                                Directory.CreateDirectory(localData);
                            }
                            string contentMailHtml = rTxtContent.Text;
                            string filename = this.idTempMail.ToString() + ".html";
                            File.WriteAllText($"{localData}\\{filename}", contentMailHtml);
                            ndMail.PATH_ATTACH = txtPathAttach.Text;
                            db.SubmitChanges();

                            this.classifyMail = 0;
                        }
                    }
                    fSendMail_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chữ đậm
        private void chữĐậmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Bold);
        }

        //Chữ nghiên
        private void chữNghiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Italic);
        }

        //Chữ gạch chân
        private void chữGạchChânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Font = new Font(rTxtContent.Font, FontStyle.Underline);
        }

        //Thoát soạn mail
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPathAttach.Text == "" && rTxtContent.Text == "")
            {
                fMail fSM = new fMail(this.userMailAcc, this.idPassLocal);
                this.Hide();
                fSM.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (this.classifyMail != 2)
                        lưuThưToolStripMenuItem_Click(sender, e);
                    fMail fSM = new fMail(this.userMailAcc, this.idPassLocal);
                    this.Hide();
                    fSM.ShowDialog();
                    this.Close();
                }
            }
        }

        //Xóa nội dung mail
        private void xóaNộiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtContent.Clear();
        }

        //Tạo trang mới
        private void tạoThưMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSendMail_Load(sender, e);
        }

        //Lưu thư vào nháp
        private void lưuThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubjectMail.Text != "")
                {
                    tempSub = txtSubjectMail.Text;
                }
                if (this.classifyMail == 0)
                {
                    //Lưu vào database
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        int tempIDNDMail = 0;
                        int tempIDStatus = 0;

                        DANHSACH_MAIL dsMail = new DANHSACH_MAIL();
                        NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                        TRANG_THAI status = new TRANG_THAI();

                        //TRẠNG THÁI
                        status.DANHDAU = false;
                        status.XOATHU = false;
                        status.STATUS_MAIL = true;
                        status.SEND_RECEIVE = false;
                        status.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                        db.TRANG_THAIs.InsertOnSubmit(status);
                        db.SubmitChanges();

                        //NỘI DUNG MAIL
                        ndMail.FROM_MAIL = txtFromMail.Text.ToLower();
                        ndMail.TO_MAIL = txtToMail.Text.ToLower();
                        ndMail.SUBJECT_MAIL = tempSub;

                        int tempidContent = 0;
                        foreach (var item in db.NOIDUNG_MAILs.ToList())
                        {
                            if (tempidContent < item.id)
                            {
                                tempidContent = item.id;
                            }
                        }
                        tempidContent++;
                        //Tạo nơi chứa
                        string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                        if (!Directory.Exists(localData))
                        {
                            Directory.CreateDirectory(localData);
                        }
                        string contentMailHtml = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>"
                            + System.Environment.NewLine
                            + System.Environment.NewLine
                            + rTxtContent.Text;
                        string filename = tempidContent.ToString() + ".html";
                        File.WriteAllText($"{localData}\\{filename}", contentMailHtml);

                        ndMail.PATH_ATTACH = txtPathAttach.Text;
                        foreach (var item in db.TRANG_THAIs.ToList())
                        {
                            if (tempIDStatus < item.id)
                                tempIDStatus = item.id;
                            ndMail.FK_id_TRANG_THAI = tempIDStatus;
                        }
                        db.NOIDUNG_MAILs.InsertOnSubmit(ndMail);
                        db.SubmitChanges();

                        //DANH SÁCH MAIL
                        dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                        dsMail.FK_id_MATKHAU_MAIL = this.idpassMail;
                        foreach (var item in db.NOIDUNG_MAILs.ToList())
                        {
                            if (tempIDNDMail < item.id)
                                tempIDNDMail = item.id;
                            dsMail.FK_id_NOIDUNG_MAIL = tempIDNDMail;
                        }
                        db.DANHSACH_MAILs.InsertOnSubmit(dsMail);
                        db.SubmitChanges();
                        MessageBox.Show("Lưu thư nháp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fSendMail_Load(sender, e);
                    }
                }
                else if (classifyMail == 1)
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                        DANHSACH_MAIL dsMail = new DANHSACH_MAIL();

                        ndMail = db.NOIDUNG_MAILs.Where(s => s.id == this.idTempMail).Single();
                        dsMail = db.DANHSACH_MAILs.Where(s => s.FK_id_NOIDUNG_MAIL == this.idTempMail).Single();

                        ndMail.TRANG_THAI.STATUS_MAIL = true;
                        ndMail.TRANG_THAI.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                        dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                        ndMail.TO_MAIL = txtToMail.Text.ToLower();
                        ndMail.SUBJECT_MAIL = tempSub;
                        //Tạo nơi chứa
                        string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                        if (!Directory.Exists(localData))
                        {
                            Directory.CreateDirectory(localData);
                        }
                        string contentMailHtml = rTxtContent.Text;
                        string filename = this.idTempMail.ToString() + ".html";
                        File.WriteAllText($"{localData}\\{filename}", contentMailHtml);
                        ndMail.PATH_ATTACH = txtPathAttach.Text;
                        db.SubmitChanges();

                        this.classifyMail = 0;
                        MessageBox.Show("Lưu thư nháp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fSendMail_Load(sender, e);
                    }
                }
                //else
                //{
                //    //Lưu vào database
                //    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                //    {
                //        int tempIDNDMail = 0;
                //        int tempIDStatus = 0;

                //        DANHSACH_MAIL dsMail = new DANHSACH_MAIL();
                //        NOIDUNG_MAIL ndMail = new NOIDUNG_MAIL();
                //        TRANG_THAI status = new TRANG_THAI();

                //        //TRẠNG THÁI
                //        status.DANHDAU = false;
                //        status.XOATHU = false;
                //        status.STATUS_MAIL = true;
                //        status.SEND_RECEIVE = false;
                //        status.UPDATE_TIME_MAIL = DateTime.Now.ToLocalTime();
                //        db.TRANG_THAIs.InsertOnSubmit(status);
                //        db.SubmitChanges();

                //        //NỘI DUNG MAIL
                //        ndMail.FROM_MAIL = txtFromMail.Text.ToLower();
                //        ndMail.TO_MAIL = txtToMail.Text.ToLower();
                //        ndMail.SUBJECT_MAIL = tempSub;

                //        int tempidContent = 0;
                //        foreach (var item in db.NOIDUNG_MAILs.ToList())
                //        {
                //            if (tempidContent < item.id)
                //            {
                //                tempidContent = item.id;
                //            }
                //        }
                //        tempidContent++;
                //        //Tạo nơi chứa
                //        string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                //        if (!Directory.Exists(localData))
                //        {
                //            Directory.CreateDirectory(localData);
                //        }
                //        string contentMailHtml = "<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>"
                //            + System.Environment.NewLine
                //            + System.Environment.NewLine
                //            + rTxtContent.Text;
                //        string filename = tempidContent.ToString() + ".html";
                //        File.WriteAllText($"{localData}\\{filename}", contentMailHtml);

                //        ndMail.PATH_ATTACH = txtPathAttach.Text;
                //        foreach (var item in db.TRANG_THAIs.ToList())
                //        {
                //            if (tempIDStatus < item.id)
                //                tempIDStatus = item.id;
                //            ndMail.FK_id_TRANG_THAI = tempIDStatus;
                //        }
                //        db.NOIDUNG_MAILs.InsertOnSubmit(ndMail);
                //        db.SubmitChanges();

                //        //DANH SÁCH MAIL
                //        dsMail.THOIGIAN_GUI = DateTime.Now.ToLocalTime();
                //        dsMail.FK_id_MATKHAU_MAIL = this.idpassMail;
                //        foreach (var item in db.NOIDUNG_MAILs.ToList())
                //        {
                //            if (tempIDNDMail < item.id)
                //                tempIDNDMail = item.id;
                //            dsMail.FK_id_NOIDUNG_MAIL = tempIDNDMail;
                //        }
                //        db.DANHSACH_MAILs.InsertOnSubmit(dsMail);
                //        db.SubmitChanges();
                //        MessageBox.Show("Lưu thư nháp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        fSendMail_Load(sender, e);
                //    }
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowser1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    txtPathAttach.Text = openFileDialog.FileName;

                if (txtPathAttach.Text.Contains(".png") || txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                {
                    if (txtPathAttach.Text.Contains(".png"))
                        txtIdentification.Text = "File: RAW";
                    else if (txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                        txtIdentification.Text = "File: PICTURE";
                }
                else if (txtPathAttach.Text.Contains(".doc") || txtPathAttach.Text.Contains(".docx"))
                    txtIdentification.Text = "File: WORD";
                else if (txtPathAttach.Text.Contains(".xls") || txtPathAttach.Text.Contains(".xlsx") || txtPathAttach.Text.Contains(".xlsm"))
                    txtIdentification.Text = "File: EXCEL";
                else if (txtPathAttach.Text.Contains(".pptx"))
                    txtIdentification.Text = "File: POWER PORINT";
                else if (txtPathAttach.Text.Contains(".pdf"))
                    txtIdentification.Text = "File: PDF ";
                else if (txtPathAttach.Text.Contains(".txt"))
                    txtIdentification.Text = "File: TEXT";
                else
                    txtIdentification.Text = "File: OTHER";
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Di chuyển form
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Load form
        private void fSendMail_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.classifyMail == 0)
                {
                    txtFromMail.Text = this.userMailAcc;
                    txtIdentification.Text = "File: ";
                    txtPathAttach.Text = "";
                    txtSubjectMail.Text = "";
                    txtToMail.Text = "";
                    rTxtContent.Text = "";
                }
                else if (this.classifyMail == 1)
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        string localData = string.Format("{0}\\DataContentEmail", Directory.GetCurrentDirectory());
                        foreach (var item in db.NOIDUNG_MAILs.ToList())
                        {
                            if (item.id == this.idTempMail)
                            {
                                txtFromMail.Text = item.FROM_MAIL;
                                txtToMail.Text = item.TO_MAIL.ToLower();
                                txtSubjectMail.Text = item.SUBJECT_MAIL;
                                rTxtContent.Text = File.ReadAllText($"{localData}\\{item.CONTENT_MAIL}", Encoding.UTF8);
                                txtPathAttach.Text = item.PATH_ATTACH;

                                if (txtPathAttach.Text.Contains(".png") || txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                                {
                                    if (txtPathAttach.Text.Contains(".png"))
                                        txtIdentification.Text = "File: RAW";
                                    else if (txtPathAttach.Text.Contains(".jpg") || txtPathAttach.Text.Contains(".jpeg"))
                                        txtIdentification.Text = "File: PICTURE";
                                }
                                else if (txtPathAttach.Text.Contains(".doc") || txtPathAttach.Text.Contains(".docx"))
                                    txtIdentification.Text = "File: WORD";
                                else if (txtPathAttach.Text.Contains(".xls") || txtPathAttach.Text.Contains(".xlsx") || txtPathAttach.Text.Contains(".xlsm"))
                                    txtIdentification.Text = "File: EXCEL";
                                else if (txtPathAttach.Text.Contains(".pptx"))
                                    txtIdentification.Text = "File: POWER PORINT";
                                else if (txtPathAttach.Text.Contains(".pdf"))
                                    txtIdentification.Text = "File: PDF ";
                                else if (txtPathAttach.Text.Contains(".txt"))
                                    txtIdentification.Text = "File: TEXT";
                                else
                                    txtIdentification.Text = "File: OTHER";
                            }
                        }
                    }
                }
                else if (this.classifyMail == 2)
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        foreach (var item in db.NOIDUNG_MAILs.ToList())
                        {
                            if (item.id == this.idTempMail)
                            {
                                txtFromMail.Text = item.FROM_MAIL;
                                string temp = item.TO_MAIL;
                                string temp1 = temp.Substring(0, temp.IndexOf(">"));
                                string temp2 = temp1.Substring(temp.IndexOf("<"));
                                string ToMail = temp2.Substring(1);

                                txtToMail.Text = ToMail.ToLower();
                                txtSubjectMail.Text = item.SUBJECT_MAIL;
                                rTxtContent.Text = "";
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
    }
}
