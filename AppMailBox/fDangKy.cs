using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fDangKy : Form
    {
        private bool checkMail;
        private bool confirmEmail;
        private int codeRD = 0;
        private string userMailAccAdmin = "appmailboxnhom8@gmail.com";
        private string userMailPassAdmin = "mailbox#nhom8";
        private string subject = "[MailBox] Mã xác thực tài khoản của bạn.";
        private string content = "";
        public fDangKy()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiện đăng kí
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (txtUserName.Text == "" || txtReEnter.Text == "" || txtPassword.Text == "" ||
                        txtLastName.Text == "" || txtFirstName.Text == "" || txtEmail.Text == "")
                        throw new Exception("Nhập đầy đủ thông tin đăng ký.");
                    else
                    {
                        using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                        {
                            MATKHAU_LOCAL mkLocal = new MATKHAU_LOCAL();
                            THONGTIN_CLIENT infoClient = new THONGTIN_CLIENT();

                            //Kiểm tra tên dăng nhập và email
                            foreach (var item in db.MATKHAU_LOCALs.ToList())
                                if (item.USERNAME_LOCAL == txtUserName.Text)
                                    throw new Exception("Tên đăng nhập này đã có người sữ dụng.");
                            foreach (var item in db.THONGTIN_CLIENTs.ToList())
                                if (item.EMAIL == txtEmail.Text.ToLower())
                                    throw new Exception("Email này đã tồn tại.");

                            if (this.checkMail && this.confirmEmail)
                            {
                                //Insert dữ liệu vào MATKHAU_LOCAL
                                mkLocal.USERNAME_LOCAL = txtUserName.Text;
                                if (txtPassword.Text == txtReEnter.Text)
                                    mkLocal.PASSWORD_LOCAL = Eramake.eCryptography.Encrypt(txtPassword.Text);
                                else
                                {
                                    txtPassword.Text = "";
                                    txtReEnter.Text = "";
                                    throw new Exception("Mật khẩu nhập lại không trùng nhau.");
                                }
                                db.MATKHAU_LOCALs.InsertOnSubmit(mkLocal);
                                db.SubmitChanges();

                                //Insert dữ liệu vào THONGTIN_CLIENT
                                infoClient.HO = txtLastName.Text;
                                infoClient.TEN = txtFirstName.Text;
                                infoClient.EMAIL = txtEmail.Text.ToLower();
                                infoClient.NTNS = dTBirth.Value;
                                //Lưu giá trị số giới tính
                                if (cmdSex.Text == "Male") infoClient.GIOITINH = 1;
                                else if (cmdSex.Text == "Female") infoClient.GIOITINH = 0;
                                else infoClient.GIOITINH = -1;
                                //Lấy khóa chính
                                int temp = 0;
                                foreach (var item in db.MATKHAU_LOCALs.ToList())
                                {
                                    if (temp <= item.id)
                                        temp = item.id;
                                    infoClient.FK_id_MATKHAU_LOCAL = item.id;
                                }
                                //Random mã pin
                                Random rdpin = new Random();
                                infoClient.MAPIN = rdpin.Next(100000, 999999);
                                infoClient.NGAYTAOTK = DateTime.Now.ToLocalTime();

                                db.THONGTIN_CLIENTs.InsertOnSubmit(infoClient);
                                db.SubmitChanges();

                                //Thông báo thành công   
                                MessageBox.Show("Đăng ký tài khoản MailBox thành công." + System.Environment.NewLine +
                                    $" Tên đăng nhập: {txtUserName.Text}" + System.Environment.NewLine +
                                    $" Mật khẩu: {txtPassword.Text}" + System.Environment.NewLine +
                                    $" Email khôi phục: {txtEmail.Text.ToLower()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fDangKy_Load(sender, e);
                            }
                            else
                            {
                                btnConfirm.BackColor = Color.Navy;
                                btnCheckMail.BackColor = Color.Navy;
                                throw new Exception("Bạn cần xác thực email trước.");
                            }
                        }
                    }
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

        //Sự kiện thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra trước khi thoát 
                if (txtUserName.Text == "" && txtReEnter.Text == "" && txtPassword.Text == "" &&
                    txtLastName.Text == "" && txtFirstName.Text == "" && txtEmail.Text == "")
                {
                    fDangNhap dn = new fDangNhap();
                    this.Hide();
                    dn.ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        fDangNhap dn = new fDangNhap();
                        this.Hide();
                        dn.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiên hiện mật khẩu
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPassword.Password = false;
                txtReEnter.Password = false;
            }
            else if (cbShowPass.Checked == false)
            {
                txtPassword.Password = true;
                txtReEnter.Password = true;
            }
        }

        //Sự kiện load form đầu tiên
        private void fDangKy_Load(object sender, EventArgs e)
        {
            cmdSex.Text = "Male";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtReEnter.Text = "";
            txtUserName.Text = "";
            cbShowPass.Checked = false;
        }

        //Đồng hồ
        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            lDate.Text = DateTime.Now.ToLongDateString();
            timer.Start();
        }

        //Đi đến đang nhập
        private void lBackLogin_Click(object sender, EventArgs e)
        {
            fDangNhap login = new fDangNhap();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        //Sự xác thực mail
        private void btnCheckMail_Click(object sender, EventArgs e)
        {
            btnCheckMail.BackColor = Color.White;
            if (this.codeRD.ToString() == txtCheckMail.Text)
            {
                this.checkMail = true;
                MessageBox.Show("Xác thực mail thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Xác thực mail thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Sự kiện kiểm email
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.White;
            //Kiểm tra định dạng email
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern) == false)
                MessageBox.Show("Định dạng email không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!txtEmail.Text.Contains("@gmail.com"))
                MessageBox.Show("MailBox chỉ hỗ trợ xác thực qua Gmail.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    Random rdpin = new Random();
                    //Kiểm tra email có thực
                    this.codeRD = rdpin.Next(100000, 999999);
                    this.content = $"Chào {txtLastName.Text}." + System.Environment.NewLine +
                                    $"Vui lòng sử dụng mã bảo mật sau cho tài khoản MailBox: {txtEmail.Text.ToLower()}." + System.Environment.NewLine +
                                    $"Mã xác thực bảo mật: {this.codeRD}" + System.Environment.NewLine +
                                    $"Hãy nhập mã xác thực tải khoản đăng ký MailBox." + System.Environment.NewLine +
                                    $"Xin cảm ơn!";
                    MailMessage mail = new MailMessage(this.userMailAccAdmin, txtEmail.Text.ToLower(), this.subject.ToString(), this.content.ToString());
                    mail.IsBodyHtml = true;
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.UseDefaultCredentials = false;
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(this.userMailAccAdmin, this.userMailPassAdmin);
                    client.EnableSsl = true;
                    client.Send(mail);

                    this.confirmEmail = true;
                    MessageBox.Show("Gửi mail xác thực thành công." + System.Environment.NewLine + "Vui lòng nhập mã để xác thực tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
