using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fMyAccount : Form
    {
        private string userMailAcc = "";
        private int idPassLocal = 0;

        public fMyAccount()
        {
            InitializeComponent();
        }

        public fMyAccount(string userMailAcc, int idPassLocal) : this()
        {
            this.userMailAcc = userMailAcc;
            this.idPassLocal = idPassLocal;
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

        //Sự kiện thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            fMail fSM = new fMail(this.userMailAcc, this.idPassLocal);
            this.Hide();
            fSM.ShowDialog();
            this.Close();
        }

        //Sự kiện load form lần đầu
        private void fMyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                {
                    foreach (var item in db.THONGTIN_CLIENTs.ToList())
                    {
                        if (this.idPassLocal == item.FK_id_MATKHAU_LOCAL)
                        {
                            txtFirstName.Text = item.HO;
                            txtLastName.Text = item.TEN;
                            txtEmail.Text = item.EMAIL;
                            if (item.GIOITINH == 0)
                            {
                                cmdSex.Text = "Female";
                            }
                            else if (item.GIOITINH == 1)
                            {
                                cmdSex.Text = "Male";
                            }
                            else
                            {
                                cmdSex.Text = "Other";
                            }
                            dTBirth.Value = Convert.ToDateTime(item.NTNS);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng liên hệ nhà phát triển.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cập nhật thông tin
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có muốn cập nhật thông tin cá nhân?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    using (dbMailBoxDataContext db = new dbMailBoxDataContext())
                    {
                        THONGTIN_CLIENT infoClient = new THONGTIN_CLIENT();

                        infoClient = db.THONGTIN_CLIENTs.Where(s => s.id == this.idPassLocal).Single();


                        infoClient.HO = txtFirstName.Text;
                        infoClient.TEN = txtLastName.Text;
                        infoClient.NTNS = dTBirth.Value;

                        if (cmdSex.Text == "Female")
                        {
                            infoClient.GIOITINH = 0;
                        }
                        else if (cmdSex.Text == "Male")
                        {
                            infoClient.GIOITINH = 1;
                        }
                        else
                        {
                            infoClient.GIOITINH = -1;
                        }
                        db.SubmitChanges();
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
