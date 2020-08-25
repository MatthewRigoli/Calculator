using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCorrectMonthlyPaymentCalculation()
        {
            MortgageCalculator calc = new MortgageCalculator();
            calc.MyMortgageAmount = 100000;
            calc.MyInterestRate = 0.0392;
            calc.MyMortgagePeriod = 30;

            double expectedResult = 472.8147315508823;

            Assert.AreEqual(expectedResult, calc.MortgagePaymentCalculator(calc.MyMortgageAmount, calc.MyInterestRate, calc.MyMortgagePeriod));
        }
    }
}