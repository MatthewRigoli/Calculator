using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MortgageCalculator
    {
        private int MortgageAmount;
        public int MyMortgageAmount
        {
            get { return MortgageAmount; }
            set { MortgageAmount = value; }
        }
        private double InterestRate;
        public double MyInterestRate
        {
            get { return InterestRate; }
            set { InterestRate = value; }
        }
        private double MortgagePeriod;
        public double MyMortgagePeriod
        {
            get { return MortgagePeriod; }
            set { MortgagePeriod = value; }
        }

        public double MortgagePaymentCalculator(int mortgageAmount, double interestRate, double mortgagePeriod)
        {
            double MonthlyInterestRate = (interestRate/12);
            Console.WriteLine(MonthlyInterestRate);
            double numMonthlyPayments = (mortgagePeriod*12);

            double firstHalf = mortgageAmount*(MonthlyInterestRate*Math.Pow(MonthlyInterestRate+1, numMonthlyPayments));
            double secondHalf = Math.Pow(MonthlyInterestRate+1, numMonthlyPayments)-1;

            double MonthlyPayment = firstHalf/secondHalf;


            return MonthlyPayment;
        }

    }
}
