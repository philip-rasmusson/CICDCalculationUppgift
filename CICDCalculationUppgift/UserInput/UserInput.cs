using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift.UserInput
{
    public class UserInput
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Num3 { get; set; }
        public string Op1 { get; set; }
        public string Op2 { get; set; }

        /// <summary>
        /// Check if user input can be converted to a double value
        /// </summary>
        /// <param name="number">
        /// user input as a string
        /// </param>
        /// <returns>
        /// True/false
        /// </returns>
        public bool CheckDouble(string number)
        {
            try
            {
                return Double.TryParse(number, out var doubleValue);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Checks if user input is an accepted operator
        /// </summary>
        /// <param name="op">
        /// User input
        /// </param>
        /// <returns>
        /// True if user input is an accepted operator, else false
        /// </returns>
        public bool CheckOperator(string op)
        {
            return (op == "+" || op == "-" || op == "*" || op == "/");
        }

        //Method to assign user input to variables
        public void CheckUserInput()
        {
            Num1 = InputNumber("first");

            Op1 = InputOperator("first");

            Num2 = InputNumber("second");

            Op2 = InputOperator("second");

            Num3 = InputNumber("third");
        }

        /// <summary>
        /// Asks user to enter a number
        /// </summary>
        /// <param name="whichNumber">
        /// Which number is beeing asked for(first, second or third)
        /// </param>
        /// <returns>
        /// User input converted to double
        /// </returns>
        private double InputNumber(string whichNumber)
        {
            double convertedToDouble;
            while (true)
            {
                Console.Write($"Enter {whichNumber} number: ");
                var input = Console.ReadLine();
                if (!CheckDouble(input)) Console.WriteLine("Invalid input, try again");
                else
                {
                    if (Convert.ToDouble(input) <= double.MaxValue)
                    {
                        convertedToDouble = Convert.ToDouble(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number too high");
                    }
                }
            }
            return convertedToDouble;
        }

        /// <summary>
        /// Asks user to enter an operator
        /// </summary>
        /// <param name="whichOperator">
        /// Which operator is beeing asked for(first or second)
        /// </param>
        /// <returns>
        /// User input as a string
        /// </returns>
        private string InputOperator(string whichOperator)
        {
            string input;
            do
            {
                Console.Write($"Enter {whichOperator} operator: ");
                input = Console.ReadLine();
                if (!CheckOperator(input)) Console.WriteLine("Invalid input, try again");
            } while (!CheckOperator(input));

            return input;
        }
    }
}