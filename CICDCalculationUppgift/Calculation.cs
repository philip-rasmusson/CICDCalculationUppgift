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
        public double Calculate(UserInput.UserInput userInput)
        
        {
            CheckFirstOp(userInput);
            return sum;
        }
        private void CheckFirstOp(UserInput.UserInput userInput)
        {
            switch (userInput.Op1)
            {
                case "+":
                    if (userInput.Op2 == "+" || userInput.Op2 == "-")
                        CheckSecondOp(userInput, Add(userInput.Num1, userInput.Num2));
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

                case "*":
                   CheckSecondOp(userInput, Multiply(userInput.Num1, userInput.Num2));
                    break;

                case "/":
                    CheckSecondOp(userInput, Divide(userInput.Num1, userInput.Num2));
                    break;
            }
        }
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
