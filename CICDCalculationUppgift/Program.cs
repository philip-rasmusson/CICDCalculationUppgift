namespace CICDCalculationUppgift
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            UserInput.UserInput userInput = new(); 

            while (run)
            {
                Console.Clear();
                //Console.Write("Enter userInput.Num1 operator: ");
                //string userInput.Op1 = Console.ReadLine();

                //Console.Write("Enter userInput.Num2 operator: ");
                //string userInput.Op2 = Console.ReadLine();

                //Console.Write("Enter userInput.Num1 number: ");
                //string first1 = Console.ReadLine();
                //double userInput.Num1 = Convert.ToDouble(first1);

                //Console.Write("Enter userInput.Num2 number : ");
                //string second2 = Console.ReadLine();
                //double userInput.Num2 = Convert.ToDouble(second2);

                //Console.Write("Enter userInput.Num3 number: ");
                //string third3 = Console.ReadLine();
                //double userInput.Num3 = Convert.ToDouble(third3);

                userInput.CheckUserInput();

                if (userInput.Op1 == "+" && userInput.Op2 == "+")
                {
                    double summa = userInput.Num1 + userInput.Num2 + userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "+" && userInput.Op2 == "-")
                {
                    double summa = userInput.Num1 + userInput.Num2 - userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "+" && userInput.Op2 == "/")
                {
                    double summa = (userInput.Num1 + userInput.Num2) / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "+" && userInput.Op2 == "*")
                {
                    double summa = (userInput.Num1 + userInput.Num2) * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "*" && userInput.Op2 == "-")
                {
                    double summa = userInput.Num1 * userInput.Num2 - userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "*" && userInput.Op2 == "+")
                {
                    double summa = userInput.Num1 * userInput.Num2 + userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "*" && userInput.Op2 == "*")
                {
                    double summa = userInput.Num1 * userInput.Num2 * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "*" && userInput.Op2 == "/")
                {
                    double summa = (userInput.Num1 * userInput.Num2) / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "-" && userInput.Op2 == "-")
                {
                    double summa = userInput.Num1 - userInput.Num2 - userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "-" && userInput.Op2 == "+")
                {
                    double summa = userInput.Num1 - userInput.Num2 + userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "-" && userInput.Op2 == "*")
                {
                    double summa = (userInput.Num1 - userInput.Num2) * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "-" && userInput.Op2 == "/")
                {
                    double summa = (userInput.Num1 - userInput.Num2) / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "/" && userInput.Op2 == "/")
                {
                    double summa = userInput.Num1 / userInput.Num2 / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "/" && userInput.Op2 == "+")
                {
                    double summa = (userInput.Num1 / userInput.Num2) + userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "/" && userInput.Op2 == "-")
                {
                    double summa = (userInput.Num1 / userInput.Num2) - userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }

                else if (userInput.Op1 == "/" && userInput.Op2 == "*")
                {
                    double summa = (userInput.Num1 / userInput.Num2) * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
