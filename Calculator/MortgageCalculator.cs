using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MortgageCalculator : ICloneable
    {
        public double MyMortgageAmount { get; set; }
        public double MyInterestRate { get; set; }
        public double MyMortgagePeriod { get; set; }
        public double MonthlyPaymentAmount { get; set; }
        
        public void MortgagePaymentCalculator()
        {
            double MonthlyInterestRate = (this.MyInterestRate/12);
            Console.WriteLine(MonthlyInterestRate);
            double numMonthlyPayments = (this.MyMortgagePeriod*12);

            double firstHalf = this.MyMortgageAmount*(MonthlyInterestRate*Math.Pow(MonthlyInterestRate+1, numMonthlyPayments));
            double secondHalf = Math.Pow(MonthlyInterestRate+1, numMonthlyPayments)-1;

            MonthlyPaymentAmount = firstHalf/secondHalf;

        }

        public object Clone()
        {
            return new MortgageCalculator
            {
                MyMortgageAmount = MyMortgageAmount,
                MyInterestRate = MyInterestRate,
                MyMortgagePeriod = MyMortgagePeriod,
                MonthlyPaymentAmount = MonthlyPaymentAmount
            };
        }

    }
}
