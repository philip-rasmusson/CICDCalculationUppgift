using NUnit.Framework;
using CICDCalculationUppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift.Tests
{
    [TestFixture()]
    public class CalculationTests
    {
        [Test()]
        [TestCase(33, 44, 55)]
        [TestCase(34234, 44443, 5523222)]
        [TestCase(0, 033, -55)]
        [TestCase(-33, -900000044, 3355)]
        [TestCase(563894239847392873743.0, 4342342423423423444, 900000055)]
        [TestCase(332423.343, 0.44, 55)]
        public void CalculateTest_Add_Add(double num1, double num2, double num3)
        {
            Calculation calc = new();
            var userInput = new UserInput.UserInput() { Num1 = num1, Num2 = num2, Num3 = num3, Op1 = "+", Op2 = "+"};
            var expected = num1 + num2 + num3;
            var actual = calc.Calculate(userInput);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        [TestCase(33, 44, 55)]
        [TestCase(34234, 44443, 5523222)]
        [TestCase(0, 033, -55)]
        [TestCase(-33, -900000044, 3355)]
        [TestCase(563894239847392873743.0, 4342342423423423444, 900000055)]
        [TestCase(332423.343, 0.44, 55)]
        public void CalculateTest_Add_Subtract(double num1, double num2, double num3)
        {
            Calculation calc = new();
            var userInput = new UserInput.UserInput() { Num1 = num1, Num2 = num2, Num3 = num3, Op1 = "+", Op2 = "-"};
            var expected = num1 + num2 - num3;
            var actual = calc.Calculate(userInput);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        [TestCase(33, 44, 55)]
        [TestCase(34234, 44443, 5523222)]
        [TestCase(0, 033, -55)]
        [TestCase(-33, -900000044, 3355)]
        [TestCase(563894239847392873743.0, 4342342423423423444, 900000055)]
        [TestCase(332423.343, 0.44, 55)]
        public void CalculateTest_Add_Multiply(double num1, double num2, double num3)
        {
            Calculation calc = new();
            var userInput = new UserInput.UserInput() { Num1 = num1, Num2 = num2, Num3 = num3, Op1 = "+", Op2 = "*"};
            var expected = num1 + num2 * num3;
            var actual = calc.Calculate(userInput);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        [TestCase(33, 44, 55)]
        [TestCase(34234, 44443, 5523222)]
        [TestCase(0, 033, -55)]
        [TestCase(-33, -900000044, 3355)]
        [TestCase(563894239847392873743.0, 4342342423423423444, 900000055)]
        [TestCase(332423.343, 0.44, 55)]
        public void CalculateTest_Divide_Subtract(double num1, double num2, double num3)
        {
            Calculation calc = new();
            var userInput = new UserInput.UserInput() { Num1 = num1, Num2 = num2, Num3 = num3, Op1 = "/", Op2 = "-"};
            var expected = num1 / num2 - num3;
            var actual = calc.Calculate(userInput);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        [TestCase(50, 45, 10)]
        public void CalculateTest_Subtract_Multiply(double num1, double num2, double num3)
        {
            Calculation calc = new();
            var userInput = new UserInput.UserInput() { Num1 = num1, Num2 = num2, Num3 = num3, Op1 = "-", Op2 = "*" };
            var expected = num1 - num2 * num3;
            var actual = calc.Calculate(userInput);
            Assert.AreEqual(expected, actual);
        }
    }
}