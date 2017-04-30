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
    public partial class Benefits : Form
    {
        public Benefits()
        {
            InitializeComponent();
            labelTitulo.Parent = pictureBox1;
        }

        private void Benefits_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
