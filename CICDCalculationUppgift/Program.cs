namespace CICDCalculationUppgift
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first operator: ");
            string op1 = Console.ReadLine();

            Console.Write("Enter second operator: ");
            string op2 = Console.ReadLine();

            Console.Write("Enter first number: ");
            string first1 = Console.ReadLine();
            double first = Convert.ToDouble(first1);

            Console.Write("Enter second number : ");
            string second2 = Console.ReadLine();
            double second = Convert.ToDouble(second2);

            Console.Write("Enter third number: ");
            string third3 = Console.ReadLine();
            double third = Convert.ToDouble(third3);

            if (op1 == "+" && op2 == "+")
            {
                double summa = first + second + third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "+" && op2 == "-")
            {
                double summa = first + second - third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "+" && op2 == "/")
            {
                double summa = (first + second) / third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "+" && op2 == "*")
            {
                double summa = (first + second) * third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "*" && op2 == "-")
            {
                double summa = first * second - third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "*" && op2 == "+")
            {
                double summa = first * second + third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "*" && op2 == "*")
            {
                double summa = first * second * third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "*" && op2 == "/")
            {
                double summa = (first * second) / third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "-" && op2 == "-")
            {
                double summa = first - second - third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "-" && op2 == "+")
            {
                double summa = first - second + third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "-" && op2 == "*")
            {
                double summa = (first - second) * third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "-" && op2 == "/")
            {
                double summa = (first - second) / third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "/" && op2 == "/")
            {
                double summa = first / second / third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "/" && op2 == "+")
            {
                double summa = (first / second) + third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "/" && op2 == "-")
            {
                double summa = (first / second) - third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }

            else if (op1 == "/" && op2 == "*")
            {
                double summa = (first / second) * third;
                Console.WriteLine(first + op1 + second + op2 + third + "=" + summa);
            }
            Console.Read();







        }
    }
}
