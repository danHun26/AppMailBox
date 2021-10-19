using EAGetMail;
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

namespace AppMailBox
{
    public partial class fMail : Form
    {
        private int idPassLocal = 0;
        private int idDSMail = 2;
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
                    foreach (var item in db.DANHSACH_MAILs.ToList())
                    {
                        //Mail nháp
                        if (item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == true)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString() && item.id == this.idDSMail)
                            {
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.MATKHAU_MAIL.id, item.NOIDUNG_MAIL.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                            }
                        }
                        //Thư mới
                        else if (item.NOIDUNG_MAIL.TRANG_THAI.STATUS_MAIL == false)
                        {
                            if (cmbEmail.Text == item.MATKHAU_MAIL.USERNAME_MAIL.ToString())
                            {
                                temp = 1;
                                fSendMail fsm = new fSendMail(item.MATKHAU_MAIL.DOMAIN_MAIL.DOMAIN, item.MATKHAU_MAIL.DOMAIN_MAIL.PORT_MAIL,
                                                            item.MATKHAU_MAIL.USERNAME_MAIL, item.MATKHAU_MAIL.PASSWORD_MAIL,
                                                            item.MATKHAU_MAIL.id, this.idPassLocal);
                                this.Hide();
                                fsm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                    //Gửi mail mới cho lần đầu
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

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            fAddEmail fAddMail = new fAddEmail(this.idPassLocal);
            this.Hide();
            fAddMail.ShowDialog();
            this.Close();
        }

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
                            if (item.id.ToString() == row.Cells[1].Value.ToString())
                                this.idDSMail = item.id;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string _generateFileName(int sequence)
        {
            DateTime currentDateTime = DateTime.Now;
            return string.Format("{0}-{1:000}-{2:000}.eml",
                currentDateTime.ToString("yyyyMMddHHmmss", new CultureInfo("en-US")),
                currentDateTime.Millisecond,
                sequence);
        }

        static void downloadMailBox()
        {
            try
            {
                // Create a folder named "inbox" under current directory
                // to save the email retrieved.
                string localInbox = string.Format("{0}\\inbox", Directory.GetCurrentDirectory());
                // If the folder is not existed, create it.
                if (!Directory.Exists(localInbox))
                {
                    Directory.CreateDirectory(localInbox);
                }

                // Gmail IMAP4 server is "imap.gmail.com"
                MailServer oServer = new MailServer("imap.gmail.com",
                                "gmailid@gmail.com",
                                "yourpassword",
                                ServerProtocol.Imap4);

                // Enable SSL connection.
                oServer.SSLConnection = true;

                // Set 993 SSL port
                oServer.Port = 993;

                MailClient oClient = new MailClient("TryIt");
                oClient.Connect(oServer);

                MailInfo[] infos = oClient.GetMailInfos();
                Console.WriteLine("Total {0} email(s)\r\n", infos.Length);
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];
                    Console.WriteLine("Index: {0}; Size: {1}; UIDL: {2}",
                        info.Index, info.Size, info.UIDL);

                    // Receive email from IMAP4 server
                    Mail oMail = oClient.GetMail(info);

                    Console.WriteLine("From: {0}", oMail.From.ToString());
                    Console.WriteLine("Subject: {0}\r\n", oMail.Subject);

                    // Generate an unqiue email file name based on date time.
                    string fileName = _generateFileName(i + 1);
                    string fullPath = string.Format("{0}\\{1}", localInbox, fileName);

                    // Save email to local disk
                    oMail.SaveAs(fullPath, true);

                    // Mark email as deleted from IMAP4 server.
                    oClient.Delete(info);
                }

                // Quit and expunge emails marked as deleted from IMAP4 server.
                oClient.Quit();
                Console.WriteLine("Completed!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Sự kiện load lại form
        private void fMail_Load(object sender, EventArgs e)
        {
            if (this.idPassLocal == 0)
            {
                fDangNhap fLogin = new fDangNhap();
                this.Hide();
                fLogin.ShowDialog();
                this.Close();
            }
        }




        private void btnInbox_Click(object sender, EventArgs e)
        {

        }
    }
}
