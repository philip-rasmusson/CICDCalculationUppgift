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

        [TestCase("")]
        [TestCase("333ddd")]
        [TestCase("..;;")]
        [TestCase(" ")]
        public void CheckOperatorTestPassIfFalse(string input)
        {
            UserInput userInput = new();
            Assert.IsFalse(userInput.CheckOperator(input));
        }
    }
}