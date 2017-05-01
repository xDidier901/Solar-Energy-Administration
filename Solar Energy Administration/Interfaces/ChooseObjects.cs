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
    public partial class ChooseObjects : Form
    {
        int hoursTV = 0, hours2 = 0, hours3 = 0, hours4 = 0, hours5 = 0, hours6 = 0, hours7 = 0;

        private void pictureBoxAddAir_Click(object sender, EventArgs e)
        {
            pictureBoxAddAir.Image = Properties.Resources.clickPlus;
            if (labelAir.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");
            }
            else
            {
                labelAir.Text = (Convert.ToInt16(labelAir.Text) + 1).ToString();
            }
        }

        private void pictureBoxSubsMicro_Click(object sender, EventArgs e)
        {
            pictureBoxSubsMicro.Image = Properties.Resources.clickSub;
            if (labelMicro.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelMicro.Text = (Convert.ToInt16(labelMicro.Text) - 1).ToString();
            }
        }

        private void pictureBoxAddMicro_Click(object sender, EventArgs e)
        {
            if (labelMicro.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");
            }
            else
            {
                labelMicro.Text = (Convert.ToInt16(labelMicro.Text) + 1).ToString();
            }
        }

        private void pictureBoxSubsWash_Click(object sender, EventArgs e)
        {
            if (labelWash.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelWash.Text = (Convert.ToInt16(labelWash.Text) - 1).ToString();
            }
        }

        private void pictureBoxAddWash_Click(object sender, EventArgs e)
        {
            if (labelWash.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");
            }
            else
            {
                labelWash.Text = (Convert.ToInt16(labelWash.Text) + 1).ToString();
            }
        }

        private void pictureBoxSubsRefr_Click(object sender, EventArgs e)
        {
            if (labelRefr.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelRefr.Text = (Convert.ToInt16(labelRefr.Text) - 1).ToString();
            }
        }

        private void pictureBoxAddRefr_Click(object sender, EventArgs e)
        {
            if (labelRefr.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");
            }
            else
            {
                labelRefr.Text = (Convert.ToInt16(labelRefr.Text) + 1).ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Introduction().Show();
        }

        private void pictureBoxSubsTV_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSubsTV.Image = Properties.Resources.hoverSub;
        }

        private void pictureBoxSubsTV_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSubsTV.Image = Properties.Resources.staticSub;
        }

        private void pictureBoxAddTV_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAddTV.Image = Properties.Resources.hoverPlus;
        }

        private void pictureBoxAddTV_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddTV.Image = Properties.Resources.staticPlus;
        }

        private void pictureBoxSubsPC_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSubsPC.Image = Properties.Resources.hoverSub;
        }

        private void pictureBoxSubsPC_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddPC.Image = Properties.Resources.staticSub;
        }

        private void pictureBoxAddPC_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAddPC.Image = Properties.Resources.hoverPlus;
        }

        private void pictureBoxAddPC_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddPC.Image = Properties.Resources.staticPlus;
        }

        private void pictureBoxSubsAir_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSubsAir.Image = Properties.Resources.hoverSub;
        }

        private void pictureBoxSubsAir_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSubsAir.Image = Properties.Resources.staticSub;
        }

        private void pictureBoxAddAir_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAddAir.Image = Properties.Resources.hoverPlus;
        }

        private void pictureBoxAddAir_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAddAir.Image = Properties.Resources.staticPlus;
        }

        private void pictureBoxSubsMicro_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSubsMicro.Image = Properties.Resources.hoverSub;
        }

        private void pictureBoxSubsMicro_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSubsMicro.Image = Properties.Resources.staticSub;
        }

        private void Lista_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void btnCalcular_MouseLeave(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.Indigo;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Font = new Font(btnCalcular.Font, FontStyle.Regular);
        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {
            btnCalcular.BackColor = Color.White;
            btnCalcular.ForeColor = Color.Indigo;
            btnCalcular.Font = new Font(btnCalcular.Font, FontStyle.Bold);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int noTv = Convert.ToInt32(labelTV.Text);
          //  MessageBox.Show(noTv.ToString());
            int horasTv = Convert.ToInt32(tbHoursTV.Text);
            int noPc = Convert.ToInt32(labelPC.Text);
            int horasPc = Convert.ToInt32(tbHoursPC.Text);
            int noAir = Convert.ToInt32(labelAir.Text);
            int horasAir = Convert.ToInt32(tbHoursAir.Text);
            int noMicro = Convert.ToInt32(labelMicro.Text);
            int horasMicro = Convert.ToInt32(tbHoursMicro.Text);
            int noWasher = Convert.ToInt32(labelWash.Text);
            int horasWasher = Convert.ToInt32(tbHoursWash.Text);
            int noRefr = Convert.ToInt32(labelRefr.Text);
            int horasRefr = Convert.ToInt32(tbHoursRefr.Text);
            Hide();
            new Calculations(noTv, horasTv, noPc, horasPc, noAir, horasAir, noMicro, horasMicro, noWasher, horasWasher, noRefr, horasRefr).Show();
        }

        private void pictureBoxSubsAir_Click(object sender, EventArgs e)
        {
            pictureBoxSubsAir.Image = Properties.Resources.clickSub;
            if (labelAir.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelAir.Text = (Convert.ToInt16(labelAir.Text) - 1).ToString();
            }
        }

        private void pictureBoxAddPC_Click(object sender, EventArgs e)
        {
            pictureBoxAddPC.Image = Properties.Resources.clickPlus;
            if (labelPC.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");
            }
            else
            {
                labelPC.Text = (Convert.ToInt16(labelPC.Text) + 1).ToString();
            }
        }

        private void pictureBoxSubsPC_Click(object sender, EventArgs e)
        {
            pictureBoxSubsPC.Image = Properties.Resources.staticSub;
            if (labelPC.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelPC.Text = (Convert.ToInt16(labelPC.Text) - 1).ToString();
            }
        }

        private void pictureBoxAddTV_Click(object sender, EventArgs e)
        {
            pictureBoxAddTV.Image = Properties.Resources.clickPlus;
            if (labelTV.Text == "50")
            {
                MessageBox.Show("You've already reach the maximum value.");    
            }
            else
            {
                labelTV.Text = (Convert.ToInt16(labelTV.Text) + 1).ToString();
            }
        }

        private void pictureBoxSubsTV_Click(object sender, EventArgs e)
        {
            pictureBoxSubsTV.Image = Properties.Resources.clickSub;
            if (labelTV.Text == "0")
            {
                MessageBox.Show("You are on the minimum value.");
            }
            else
            {
                labelTV.Text = (Convert.ToInt16(labelTV.Text) - 1).ToString();
            }
        }

        public ChooseObjects()
        {
            InitializeComponent();
            hora1.Parent = pictureBox1;
            hora1.BackColor = Color.Transparent;
            hora2.Parent = pictureBox1;
            hora2.BackColor = Color.Transparent;
            hora3.Parent = pictureBox1;
            hora3.BackColor = Color.Transparent;
            hora4.Parent = pictureBox1;
            hora4.BackColor = Color.Transparent;
            hora5.Parent = pictureBox1;
            hora5.BackColor = Color.Transparent;
            hora6.Parent = pictureBox1;
            hora6.BackColor = Color.Transparent;

            labelTitulo.Parent= pictureBox1;
            labelSubtitulo.Parent = pictureBox1;

            pictureBoxAddAir.Parent = pictureBox1;
            pictureBoxAddAir.BackColor = Color.Transparent;

            btnReturn.BackColor = Color.Indigo;
            btnReturn.ForeColor = Color.White;
            btnReturn.Font = new Font(btnReturn.Font, FontStyle.Regular);

            btnCalcular.BackColor = Color.Indigo;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Font = new Font(btnCalcular.Font, FontStyle.Regular);
        }
    }
}
