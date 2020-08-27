using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace MortgageCalc.WinForms
{
    public partial class Form1 : Form
    {
        MortgageCalculator MortCalc = new MortgageCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyPaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void MonthMortPaymentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            MortCalc.MyMortgageAmount = double.Parse(MortAmountBox.Text);
            MortCalc.MyInterestRate = double.Parse(InterestRateAmountBox.Text);
            MortCalc.MyMortgagePeriod = double.Parse(MortPeriodBox.Text);

            double result = MortCalc.MortgagePaymentCalculator(MortCalc.MyMortgageAmount, MortCalc.MyInterestRate, MortCalc.MyMortgagePeriod);

            MonthMortPaymentBox.Text = result.ToString("c");
        }
    }
}
