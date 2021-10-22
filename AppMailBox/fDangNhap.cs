using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Sự kiện thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra trước khi thoát form
                if (txtUsername.Text == "" && txtPassword.Text == "") this.Close();
                else
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                        this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện đồng hồ
        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        //Sự kiện di chuyên form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiên đăng kí
        private void label2_Click(object sender, EventArgs e)
        {
            fDangKy signup = new fDangKy();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        //Sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        if (txtPassword.Text == "" || txtUsername.Text == "") throw new Exception("Nhập thông tin đầy đủ.");
                        int temp = 0;
                        foreach (var item in db.MATKHAU_LOCALs.ToList())
                        {
                            if (item.USERNAME_LOCAL == txtUsername.Text
                                && txtPassword.Text == Eramake.eCryptography.Decrypt(item.PASSWORD_LOCAL))
                            {
                                temp++;
                                foreach (var item2 in db.THONGTIN_CLIENTs.ToList())
                                {
                                    if (item2.FK_id_MATKHAU_LOCAL == item.id)
                                    {
                                        fDangNhap_Load(sender, e);
                                        fMail fSM = new fMail(item.id);
                                        this.Hide();
                                        fSM.ShowDialog();
                                        this.Close();
                                        break;
                                    }
                                }
                            }
                        }
                        if (temp == 0)
                        {
                            // txtUsername.Text = "";
                            txtPassword.Text = "";
                            //txtUsername.Hint = "Re-enter username";
                            txtPassword.Hint = "Re-enter password";
                            throw new Exception("Tên đăng nhập hoặc mật khẩu không đúng.");
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

        //Sự kiện đăng nhập
        private void fDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Hint = "Username:";
            txtPassword.Hint = "Password:";
        }

        private void lForgotPW_Click(object sender, EventArgs e)
        {
            fQuenMatKhau signup = new fQuenMatKhau();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }
    }
}
