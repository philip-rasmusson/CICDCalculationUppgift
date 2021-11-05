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
