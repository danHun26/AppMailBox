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
    public partial class fQuenMatKhau : Form
    {
        private string userMailAccAdmin = "appmailboxnhom8@gmail.com";
        private string userMailPassAdmin = "mailbox#nhom8";
        private string subject = "[MailBox] Mã khôi phục tài khoản của bạn!";
        private string content = "";
        private int idMK = 0;
        private int tempShowPass = 0;
        public fQuenMatKhau()
        {
            InitializeComponent();
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void fQuenMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Sự kiện khôi phục mật khẩu
        private void btnContinueStep1_Click(object sender, EventArgs e)
        {

        }

        //Sự kiện xác nhận mã pin
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        int temp = 0;
                        foreach (var item in db.THONGTIN_CLIENTs.ToList())
                        {
                            if (txtPin.Text == item.MAPIN.ToString())
                            {
                                temp = 1;
                                txtPassword.Enabled = true;
                                txtReEnter.Enabled = true;
                                btnContinueStep2.Enabled = true;
                                btnReadPw1.Enabled = true;
                                btnReadPw2.Enabled = true;
                                throw new Exception("Xác nhận mã pin thành công" + Environment.NewLine + "Mời qua bước 2 đặt lại mật khẩu mới!");
                            }
                        }
                        if (temp == 0) throw new Exception("Mã khôi phục không chính xác!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please contact the developer!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện quay lại đăng nhập
        private void btnBackStep1_Click(object sender, EventArgs e)
        {
            //Kiểm tra trước khi thoát 
            if (txtEmail.Text == "" && txtPassword.Text == "" && txtPin.Text == "" && txtReEnter.Text == "")
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

        //Hiển thị mật khẩu
        private void btnReadPw1_Click(object sender, EventArgs e)
        {
            tempShowPass++;
            if (tempShowPass % 2 == 0)
            {
                txtPassword.Password = true;
                txtReEnter.Password = true;
            }
            else
            {
                txtPassword.Password = false;
                txtReEnter.Password = false;
            }
        }

        //Thay đổi mật khẩu
        private void btnContinueStep2_Click(object sender, EventArgs e)
        {

        }

        //Sự kiên load lại form
        private void fQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPin.Text = "";
            txtReEnter.Text = "";
            txtPin.Enabled = false;
            btnAccept.Enabled = false;
            txtPassword.Enabled = false;
            btnContinueStep2.Enabled = false;
            btnReadPw1.Enabled = false;
            txtReEnter.Enabled = false;
            btnReadPw2.Enabled = false;
        }
    }
}
