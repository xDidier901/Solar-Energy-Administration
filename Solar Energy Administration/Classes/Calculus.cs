using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_Energy_Administration.Classes
{
    class Calculus
    {
        double consumoTv = 0, consumoRefr = 0, consumoAir = 0, consumoMicro = 0, consumoWasher = 0, consumoPc = 0, consumoTotal = 0;

        public void television(int quantity, int hours)
        {
            //60 is an average of tv consumption in W/h. Hours is the hours per week. Quantity is the amount of tv's. 4 is the constant to for 4 weeks 
            consumoTv = 60 * hours * quantity * 4;
        }

        public void refrigerator(int quantity, int hours)
        {
            //86 is an average of tv consumption in W/h. Hours is the hours per week. Quantity is the amount of refrigerators. 4 is the constant to for 4 weeks 
            consumoRefr = 86 * hours * quantity * 4;
        }

        public void air(int quantity, int hours)
        {
            consumoAir = 1170 * hours * quantity * 4;
        }

        public void microwave(int quantity, int hours)
        {
            consumoMicro = 1550 * hours * quantity * 4;
        }

        public void washer(int quantity, int hours)
        {
            consumoWasher = 120 * hours * quantity * 4;
        }

        public void pc(int quantity, int hours)
        {
            consumoPc = 173 * hours * quantity * 4;
        }

        public double getTotalConsumption()
        {
            consumoTotal = consumoAir + consumoMicro + consumoPc + consumoRefr + consumoTv + consumoWasher;
            return consumoTotal;
        }

        public double quantityPanels()
        {
            double consumoTotal = getTotalConsumption();
            double numberPanels = (consumoTotal) / (30 * 275 * 6);

            if (numberPanels <= 0.5)
            {
                numberPanels = 1;
            }
            else if (numberPanels > 0.5 && numberPanels < 0.9)
            {
                numberPanels = 1;
            }
            else
            {
                numberPanels = Math.Round(numberPanels, 2);
            }
            return numberPanels;
        }

        public double moneySpent()
        {
            double consumoMonth = getTotalConsumption();
            double moneySpent = (consumoMonth/1000) * 0.15;
            return moneySpent;
        }

        public double investmentReturn()
        {
            double numbersPanels = quantityPanels();
            double month = moneySpent() ;

            double investment = (numbersPanels * 375) / month;
            return investment;
        }
    }
}
