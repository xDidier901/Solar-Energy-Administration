using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_Energy_Administration.Interfaces
{
    public partial class Calculations : Form
    {
        public Calculations()
        {
            InitializeComponent();
            labelCalculo.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            //label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;

            btnBenefits.BackColor = Color.Indigo;
            btnBenefits.ForeColor = Color.White;
            btnBenefits.Font = new Font(btnBenefits.Font, FontStyle.Regular);

            btnReturn.BackColor = Color.Indigo;
            btnReturn.ForeColor = Color.White;
            btnReturn.Font = new Font(btnReturn.Font, FontStyle.Regular);
        }

        private void Calculations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new ChooseObjects().Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Hide();
            new Benefits().Show();
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.Indigo;
            btnReturn.ForeColor = Color.White;
            btnReturn.Font = new Font(btnReturn.Font, FontStyle.Regular);
        }

        private void btnReturn_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.White;
            btnReturn.ForeColor = Color.Indigo;
            btnReturn.Font = new Font(btnReturn.Font, FontStyle.Bold);
        }

        private void btnCalcular_MouseLeave(object sender, EventArgs e) {
            btnBenefits.BackColor = Color.Indigo;
            btnBenefits.ForeColor = Color.White;
            btnBenefits.Font = new Font(btnBenefits.Font, FontStyle.Regular);
        }

        private void btnBenefits_MouseEnter(object sender, EventArgs e)
        {
            btnBenefits.BackColor = Color.White;
            btnBenefits.ForeColor = Color.Indigo;
            btnBenefits.Font = new Font(btnBenefits.Font, FontStyle.Bold);
        }
    }
}
