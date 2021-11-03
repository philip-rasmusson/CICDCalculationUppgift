using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDCalculationUppgift
{
    class Calculator
    {


        public static void calculator()
        {
            bool run = true;
            while (run)
            {
                int temp = int.MaxValue;
                //Console.WriteLine("Calculator\n\n\n");

                if (temp != int.MaxValue)
                {

                }
                Console.WriteLine("Enter a number");
                var num1 = Console.ReadLine();
                Console.WriteLine("Enter an operator");
                string oper = Console.ReadLine();
                Console.WriteLine("Enter a 2nd number");
                var num2 = Console.ReadLine();

               
                int result = 0;
                if(oper == "+")
                {
                   result = addition(Convert.ToInt32(num1), Convert.ToInt32(num2));
                }
                else if(oper == "-")
                {
                   result = subtract(Convert.ToInt32(num1), Convert.ToInt32(num2));
                }
                else if(oper == "*")
                {
                    result = multiply(Convert.ToInt32(num1), Convert.ToInt32(num2));
                }

                else if(oper == "/")
                {
                    result = divide(Convert.ToInt32(num1), Convert.ToInt32(num2));
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                Console.WriteLine(result);
                temp = result;




                //switch (oper)
                //{


                //    case "+":
                //        result = addition(Convert.ToInt32(num1), Convert.ToInt32(num2)); 
                //        break;
                //    case "*":
                //        result = multiply(Convert.ToInt32(num1), Convert.ToInt32(num2));
                //        break;
                //    case "-":
                //        var result = subtract(Convert.ToInt32(num1), Convert.ToInt32(num2));
                //        break;
                //    case "/":
                //        var result = divide(Convert.ToInt32(num1), Convert.ToInt32(num2));
                //        break;

                //    default:
                //        break;
                //}
            }



        }

        public static int divide(int a, int b) {
            return a / b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int addition(int a, int b)
        {
            return a + b;
        }

        public static int subtract(int a, int b)
        {
            return a - b;
        }
    }
}
