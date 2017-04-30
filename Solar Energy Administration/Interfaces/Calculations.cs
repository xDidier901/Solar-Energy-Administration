using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solar_Energy_Administration.Classes;

namespace Solar_Energy_Administration.Interfaces
{
    public partial class Calculations : Form
    {
        private Calculus objCal;
        int noTv=0;
        int horasTv=0;
        int noPc=0;
        int horasPc=0;
        int noair=0;
        int horasAir=0;
        int noMicro=0;
        int horasMicro=0;
        int noWasher=0;
        int horasWasher=0;
        int noRefr=0; 
        int horasRefr=0;

        public Calculations(int noTv, int horasTv, int noPc, int horasPc, int noair, int horasAir, int noMicro, int horasMicro, int noWasher, int horasWasher, int noRefr, int horasRefr)
        {
            InitializeComponent();
            objCal = new Calculus();
            Console.WriteLine("objeto creado en constructor");
            this.noTv = noTv;
            this.horasTv = horasTv;
            this.noPc = noPc;
            this.horasPc = horasPc;
            this.noair = noair;
            this.horasAir = horasAir;
            this.noMicro = noMicro;
            this.horasMicro = horasMicro;
            this.noWasher = noWasher;
            this.horasWasher = horasWasher;
            this.noRefr = noRefr;
            this.horasRefr = horasRefr;

            
            objCal.air(noair, horasAir);
            objCal.microwave(noMicro, horasMicro);
            objCal.refrigerator(noRefr, horasRefr);
            objCal.television(noTv, horasTv);
            objCal.washer(noWasher, horasWasher);
            objCal.pc(noPc, horasPc);

            labelConsumoMensual.Text = objCal.getTotalConsumption().ToString();
            labelConsumoMensual.Text = (((objCal.getTotalConsumption()) / 1000).ToString()) + " kW/h";
            labelMoneySpent.Text = ((objCal.moneySpent().ToString()) + " Dollars");
            
            labelNumberPanles.Text = String.Format("{0:0.00}", objCal.quantityPanels()) + "Panels";
            labelInvestment.Text = String.Format("{0:0.00}", objCal.investmentReturn()) + " Month";

            // getResults(objCal);

           
            labelCalculo.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            //label3.Parent = pictureBox1;
            labelConsumoMensual.Parent = pictureBox1;
            labelMoneySpent.Parent = pictureBox1;
            labelNumberPanles.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            labelInvestment.Parent = pictureBox1;
            label9.Parent = pictureBox1;

            btnBenefits.BackColor = Color.Indigo;
            btnBenefits.ForeColor = Color.White;
            btnBenefits.Font = new Font(btnBenefits.Font, FontStyle.Regular);

            btnReturn.BackColor = Color.Indigo;
            btnReturn.ForeColor = Color.White;
            btnReturn.Font = new Font(btnReturn.Font, FontStyle.Regular);
        }

        public void calculos()
        {
           
            objCal.air(noair, horasAir);
            objCal.microwave(noMicro, horasMicro);
            objCal.refrigerator(noRefr, horasRefr);
            objCal.television(noTv, horasTv);
            objCal.washer(noWasher, horasWasher);
            objCal.pc(noPc, horasPc);
        }

        private void getResults(Calculus objCal)
        {
            Console.WriteLine("Entre al metodo");
            

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
            //Send info to next frame
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
