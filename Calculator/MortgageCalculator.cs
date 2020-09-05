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

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case nameof(MyMortgageAmount):
                        if (MyMortgageAmount > 5000000)
                            return "Mortgage amount cannot exceed $5,000,000";
                        else if (MyMortgageAmount <= 0)
                            return "Mortgage amount cannot be less than or equal to $0.00";
                        break;
                    case nameof(MyInterestRate):
                        if (MyInterestRate > 1)
                            return "Interest rate cannot exceed 100%";
                        else if (MyInterestRate <= 0)
                            return "Interest rate cannot be less than or equal to 0%";
                        break;
                    case nameof(MyMortgagePeriod):
                        if(MyMortgagePeriod > 65)
                                return "Mortgage period cannot be longer than 65 years";
                        else if(MyMortgagePeriod<= 0)
                                return "Mortgage period cannot be less than or equal to 0 years";
                        break;
                }
                return string.Empty;
            }
        }

    }
}
