using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift
{
    public class Calculation
    {
        public double tempSumOne { get; set; }
        public double tempSumTwo { get; set; }
        public double sum { get; set; }
        /// <summary>
        /// Calculate user inputs
        /// </summary>
        /// <param name="userInput">An object containing values from user input</param>
        /// <returns>Value from calclation</returns>
        public double Calculate(UserInput.UserInput userInput)
        
        {
            CheckFirstOp(userInput);
            return sum;
        }
        /// <summary>
        /// Checks the first operator
        /// </summary>
        /// <param name="userInput">An object containing values from user input</param>
        private void CheckFirstOp(UserInput.UserInput userInput)
        {
            switch (userInput.Op1)
            {
                //If Op1 is + or - and Op2 is + or - we can add/subtract Num1, Num2 and Num3
                //with no regards to rules of priority
                case "+":
                    if (userInput.Op2 == "+" || userInput.Op2 == "-")
                        CheckSecondOp(userInput, Add(userInput.Num1, userInput.Num2));
                    //If Op1 is + or - and Op2 is * or /, we must calculate Num2 to Num3 first, and then 
                    //add/subtract Num1 to that result
                    else if (userInput.Op2 == "*")
                        sum = Add(userInput.Num1, Multiply(userInput.Num2, userInput.Num3));
                    else
                        sum = Add(userInput.Num1, Divide(userInput.Num2, userInput.Num3));
                    break;

                case "-":
                    if (userInput.Op2 == "+" || userInput.Op2 == "-")
                        CheckSecondOp(userInput, Subtract(userInput.Num1, userInput.Num2));
                    else if (userInput.Op2 == "*")
                        sum = Subtract(userInput.Num1, Multiply(userInput.Num2, userInput.Num3));
                    else
                        sum = Subtract(userInput.Num1, Divide(userInput.Num2, userInput.Num3));
                    break;
                //If Op1 is * or /, we can multiply/divide Num1 and Num2, and calculate with Num3 according to Op2
                case "*":
                   CheckSecondOp(userInput, Multiply(userInput.Num1, userInput.Num2));
                    break;

                case "/":
                    CheckSecondOp(userInput, Divide(userInput.Num1, userInput.Num2));
                    break;
            }
        }
        /// <summary>
        /// Checks second operator
        /// </summary>
        /// <param name="userInput">An object containing values from user input</param>
        /// <param name="tempSumOne">Calculation of Num1 and Num2</param>
        private void CheckSecondOp(UserInput.UserInput userInput, double tempSumOne)
        {
            switch (userInput.Op2)
            {
                case "+":
                    sum = Add(tempSumOne, userInput.Num3);
                    break;
             
                case "-":
                    sum = Subtract(tempSumOne, userInput.Num3);
                    break;
             
                case "*":
                    sum = Multiply(tempSumOne, userInput.Num3);
                    break;
             
                case "/":
                    sum = Divide(tempSumOne, userInput.Num3);
                    break;
            }
        }
        private double Multiply(double a, double b)
        {
            return a * b;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }
        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Subtract(double a, double b)
        {
            return a - b;
        }

    }
}
