using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppMailBox
{
    public partial class fAbout : Form
    {
        private string userMailAcc = "";
        private int idPassLocal = 0;
        public fAbout()
        {
            InitializeComponent();
        }

        public fAbout(string userMailAcc, int idPassLocal) : this()
        {
            this.userMailAcc = userMailAcc;
            this.idPassLocal = idPassLocal;
        }

        //Di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/danHun26/AppMailBox.git");
            Process.Start(sInfo);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //Sự kiện thoát
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            fMail fSM = new fMail(this.userMailAcc, this.idPassLocal);
            this.Hide();
            fSM.ShowDialog();
            this.Close();
        }
    }
}
