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
            btnData.Font = new Font(btnData.Font, FontStyle.Regular);
            pictureBox3.BackColor = Color.Transparent;
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
        }

        private void btnData_MouseEnter(object sender, System.EventArgs e)
        {
            btnData.BackColor = Color.White;
            btnData.ForeColor = Color.Indigo;
            btnData.Font = new Font(btnData.Font, FontStyle.Bold);
        }

        private void btnData_MouseLeave(object sender, System.EventArgs e)
        {


            btnData.BackColor = Color.Indigo;
            btnData.ForeColor = Color.White;
            btnData.Font = new Font(btnData.Font, FontStyle.Regular);
        }

        private void btnData_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void videoPlayer_StatusChange(object sender, System.EventArgs e)
        {

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
