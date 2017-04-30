using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solar_Energy_Administration.Interfaces;

namespace Solar_Energy_Administration
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Regular);
            videoPlayer.URL = @"C:\Users\Didier Valdez\Desktop\PA\Solar Energy Administration\Video.mp4";
            videoPlayer.uiMode = "none";
            labelTitulo.Parent = pictureBox1;
            labelTitulo.BackColor = Color.Transparent;
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void Introduction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new ChooseObjects().Show();
           
        }

        private void btnData_MouseLeave(object sender, EventArgs e)
        {
            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Regular);
        }

        private void btnData_MouseEnter(object sender, EventArgs e)
        {
            btnData.BackColor = Color.White;
            btnData.ForeColor = Color.Indigo;
            btnData.Font = new Font(btnData.Font, FontStyle.Bold);
        }

        private void videoPlayer_StatusChange(object sender, EventArgs e)
        {
            if (videoPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                videoPlayer.Visible = false;
            }
        }
    }
}
