using _03_Classes.Members;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Classes.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorTest()
        {
            Calculator calc = new Calculator();

            double quotient = calc.Divide(9, 2);
            Console.WriteLine(quotient);
            //or
            Console.WriteLine(calc.DivideMixed(9, 2));
        }
    }
}
