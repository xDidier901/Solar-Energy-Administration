using System.Drawing;
using System.Windows.Forms;

namespace Solar_Energy_Administration
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Bold);
            pictureBox3.BackColor = Color.Transparent;
            label1.Parent = pictureBox3;
            label2.Parent = pictureBox3;
            label3.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            //videoPlayer.URL = @"C:\Users\Didier Valdez\Desktop\PA\Solar Energy Administration\Video.mp4";
            //videoPlayer.uiMode = "none";
        }

        private void btnData_MouseEnter(object sender, System.EventArgs e)
        {
            btnData.BackColor = Color.White;
            btnData.ForeColor = Color.Indigo;
            btnData.Font = new Font(btnData.Font, FontStyle.Regular);
        }

        private void btnData_MouseLeave(object sender, System.EventArgs e)
        {
            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Bold);
        }

        private void btnData_MouseDown(object sender, MouseEventArgs e)
        {
            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Bold);

        }

        private void videoPlayer_StatusChange(object sender, System.EventArgs e)
        {
            //if (videoPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            // {
            //     videoPlayer.Visible = false;
            // }
        }

        private void StartScreen_Load(object sender, System.EventArgs e)
        {

        }

        private void btnData_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new Introduction().Show();
        }
    }
}
