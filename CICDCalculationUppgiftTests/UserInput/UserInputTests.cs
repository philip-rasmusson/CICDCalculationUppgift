using NUnit.Framework;
using CICDCalculationUppgift.UserInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift.UserInput.Tests
{
    [TestFixture()]
    public class UserInputTests
    {
        [Test()]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("*")]
        [TestCase("/")]
        public void CheckOperatorTestPassIfTrue(string input)
        {
            UserInput userInput = new();
            Assert.IsTrue(userInput.CheckOperator(input));
        }
        [Test()]
        [TestCase("")]
        [TestCase("333ddd")]
        [TestCase("..;;")]
        [TestCase(" ")]
        public void CheckOperatorTestPassIfFalse(string input)
        {
            UserInput userInput = new();
            Assert.IsFalse(userInput.CheckOperator(input));
        }

        [Test()]
        [TestCase("1")]
        [TestCase("9999992222")]
        [TestCase("233,33444")]
        [TestCase("1,0")]
        public void CheckDoubleTestPassIfTrue(string input)
        {
            UserInput userInput = new();
            Assert.IsTrue(userInput.CheckDouble(input));
        }
        [Test()]
        [TestCase("")]
        [TestCase("22,33..44")]
        [TestCase("333ddd")]
        [TestCase("..;;")]
        [TestCase(" ")]
        public void CheckDoubleTestPassIfFalse(string input)
        {
            UserInput userInput = new();
            Assert.IsFalse(userInput.CheckDouble(input));
        }
    }
    
}