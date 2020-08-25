using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MortgageCalculator calc = new MortgageCalculator();
            calc.MyInterestRate = 0.0392;
            calc.MyMortgageAmount = 100000;
            calc.MyMortgagePeriod = 30;

            Console.WriteLine(calc.MortgagePaymentCalculator(calc.MyMortgageAmount, calc.MyInterestRate, calc.MyMortgagePeriod));
        }
    }
}
