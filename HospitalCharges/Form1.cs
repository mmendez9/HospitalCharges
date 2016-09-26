using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Days charges
            private double CalcStayCharges()
        {
            double days;
            double.TryParse(numDays.Text, out days);
            double charges = days * 350;
            Console.WriteLine(days);
            return charges;
        }

        // Medication, Surgical, Lab & Physical Rehab charges
        private double CalMiscCharges()
        {
            int medication;
            int.TryParse(med.Text,out medication);
            int surgical;
            int.TryParse(surgch.Text, out surgical);
            int labFee;
            int.TryParse(labch.Text, out labFee);
            int physical;
            int.TryParse(phychar.Text, out physical);
            int totalch;

            totalch = medication + surgical + labFee + physical;
            Console.WriteLine(totalch);

            return totalch;
        }

        private double CalTotalCharges()
        {
            double totalch = (CalcStayCharges() + CalMiscCharges());
            return totalch;
        }

        private void cal_Click(object sender, EventArgs e)
        {
            total.Text = CalTotalCharges().ToString("C");
        }
    }
}
