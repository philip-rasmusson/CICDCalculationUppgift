using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift.UserInput
{
    public class UserInput
    {
        public string Op1 { get; set; }
        public string Op2 { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Num3 { get; set; }

        public void CheckUserInput()
        {
            Num1 = InputNumber("first");

            Op1 = InputOperator("first");

            Num2 = InputNumber("second");

            Op1 = InputOperator("second");

            Num3 = InputNumber("third");
        }
        private double InputNumber(string order)
        {
            double convertedToDouble;
            do
            {
                Console.Write($"Enter {order} number: ");
                string input = Console.ReadLine();
                if (!CheckDouble(input)) Console.WriteLine("Invalid input, try again");
                else
                {
                    convertedToDouble = Convert.ToDouble(input);
                    break;
                }
            } while (true);

            return convertedToDouble;
        }

        private string InputOperator(string order)
        {
            string input;
            do
            {
                Console.Write($"Enter {order} operator: ");
                input = Console.ReadLine();
                if (!CheckOperator(input)) Console.WriteLine("Invalid input, try again");
            } while (!CheckOperator(input));

            return input;
        }
        private bool CheckOperator(string op)
        {
            return (op == "+" || op == "-" || op == "*" || op == "/");              
        }
        private bool CheckDouble(string number)
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
    }
}
