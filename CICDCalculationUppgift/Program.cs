namespace CICDCalculationUppgift
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            new Welcome().DisplayMessageAndMenu();
            Console.ReadKey();
            bool run = true;
            while (run)
            {
                Console.Clear();
                //Creates a new instance of UserInput with no value assigned
                UserInput.UserInput userInput = new();
                //Runs method to ask for user input
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
                    double summa = userInput.Num1 + userInput.Num2 / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "+" && userInput.Op2 == "*")
                {
                    double summa = userInput.Num1 + userInput.Num2 * userInput.Num3;
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
                    double summa = userInput.Num1 * userInput.Num2 / userInput.Num3;
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
                    double summa = userInput.Num1 - userInput.Num2 * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "-" && userInput.Op2 == "/")
                {
                    double summa = userInput.Num1 - userInput.Num2 / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "/")
                {
                    double summa = userInput.Num1 / userInput.Num2 / userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "+")
                {
                    double summa = userInput.Num1 / userInput.Num2 + userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "-")
                {
                    double summa = userInput.Num1 / userInput.Num2 - userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "*")
                {
                    double summa = userInput.Num1 / userInput.Num2 * userInput.Num3;
                    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                }
            }
        }
    }
}