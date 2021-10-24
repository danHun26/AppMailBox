using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fFeedback : Form
    {
        private string star = "";
        private string userMailAcc = "";
        private string passMailAcc = "";
        private int idPassLocal = 0;
        private string userMailAccAdmin = "appmailboxnhom8@gmail.com";
        private string serverMail = "";
        private int portServerMail = 0;
        private string Email_Local = "";

        public fFeedback()
        {
            InitializeComponent();
        }

        public fFeedback(string userMailAcc, string passMailAcc,  
            int idPassLocal, string serverMail, int portServerMail, string Email_Local) : this()
        {
            this.userMailAcc = userMailAcc;
            this.passMailAcc = Eramake.eCryptography.Decrypt(passMailAcc);
            this.idPassLocal = idPassLocal;
            this.serverMail = serverMail;
            this.portServerMail = portServerMail;
            this.Email_Local = Email_Local;
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSendFB_Click(object sender, EventArgs e)
        {
            try
            {
                string subjectMail = "[MailBox] PHIẾU BÁO CÁO VẤN ĐỀ KHÁCH HÀNG.";
                string contentMail = "";
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.MATKHAU_MAILs.ToList())
                    {
                        if (item.USERNAME_MAIL == this.userMailAcc)
                        {
                            contentMail = "Ngày gửi báo cáo:" + DateTime.Now.ToLocalTime() + System.Environment.NewLine +
                                "Khách hàng: " + this.Email_Local + System.Environment.NewLine +
                                "Nội dung phản hồi: " + rtxFeedback.Text + " " + System.Environment.NewLine +
                                "Khách hàng đánh giá: " + this.star;
                        }
                    }
                }

                MailMessage mail = new MailMessage(this.userMailAcc, userMailAccAdmin, subjectMail, contentMail);
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient(this.serverMail);
                client.UseDefaultCredentials = false;
                client.Port = this.portServerMail;
                client.Credentials = new System.Net.NetworkCredential(this.userMailAcc, this.passMailAcc);
                client.EnableSsl = true;
                try
                {
                    client.Send(mail);
                    MessageBox.Show("Cảm ơn bạn đã gửi đánh giá về cho chúng tôi." + System.Environment.NewLine +
                    "Những ý kiến đóng góp của bạn sẽ giúp chúng tôi phát triển úng dụng tốt hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fFeedback_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có sự cố xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Sự kiện đánh 1 sao
        private void btnS1_Click(object sender, EventArgs e)
        {
            this.star = "1 SAO";
            btnS1.BackColor = Color.FromArgb(255, 255, 128);
            btnS2.BackColor = Color.FloralWhite;
            btnS3.BackColor = Color.FloralWhite;
            btnS4.BackColor = Color.FloralWhite;
            btnS5.BackColor = Color.FloralWhite;
        }
        //Sự kiện đánh 2 sao
        private void btnS2_Click(object sender, EventArgs e)
        {
            this.star = "2 SAO";
            btnS1.BackColor = Color.FromArgb(255, 255, 128);
            btnS2.BackColor = Color.FromArgb(255, 255, 128);
            btnS3.BackColor = Color.FloralWhite;
            btnS4.BackColor = Color.FloralWhite;
            btnS5.BackColor = Color.FloralWhite;
        }
        //Sự kiện đánh 3 sao
        private void btnS3_Click(object sender, EventArgs e)
        {
            this.star = "3 SAO";
            btnS1.BackColor = Color.FromArgb(255, 255, 128);
            btnS2.BackColor = Color.FromArgb(255, 255, 128);
            btnS3.BackColor = Color.FromArgb(255, 255, 128);
            btnS4.BackColor = Color.FloralWhite;
            btnS5.BackColor = Color.FloralWhite;
        }
        //Sự kiện đánh 4 sao
        private void btnS4_Click(object sender, EventArgs e)
        {
            this.star = "4 SAO";
            btnS1.BackColor = Color.FromArgb(255, 255, 128);
            btnS2.BackColor = Color.FromArgb(255, 255, 128);
            btnS3.BackColor = Color.FromArgb(255, 255, 128);
            btnS4.BackColor = Color.FromArgb(255, 255, 128);
            btnS5.BackColor = Color.FloralWhite;
        }
        //Sự kiện đánh 5 sao
        private void btnS5_Click(object sender, EventArgs e)
        {
            this.star = "5 SAO";
            btnS1.BackColor = Color.FromArgb(255, 255, 128);
            btnS2.BackColor = Color.FromArgb(255, 255, 128);
            btnS3.BackColor = Color.FromArgb(255, 255, 128);
            btnS4.BackColor = Color.FromArgb(255, 255, 128);
            btnS5.BackColor = Color.FromArgb(255, 255, 128);
        }

        //Sự kiện thoát form
        private void btnClose_Click(object sender, EventArgs e)
        {
            fMail fSM = new fMail(this.userMailAcc, this.idPassLocal);
            this.Hide();
            fSM.ShowDialog();
            this.Close();
        }


        //Sự kiện load lại form sau khi gửi
        private void fFeedback_Load(object sender, EventArgs e)
        {
            this.star = "";
            rtxFeedback.Text = "";
            btnS1.BackColor = Color.FloralWhite;
            btnS2.BackColor = Color.FloralWhite;
            btnS3.BackColor = Color.FloralWhite;
            btnS4.BackColor = Color.FloralWhite;
            btnS5.BackColor = Color.FloralWhite;
        }

        //Sự kiên di chuyển form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
