namespace CICDCalculationUppgift
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Calculation calc = new();

            while (run)
            {
                Console.Clear();
                //Creates a new instance of UserInput with no value assigned
                UserInput.UserInput userInput = new();
                //Runs method to ask for user input
                userInput.CheckUserInput();
                //Prints the result of calculatino
                Console.WriteLine($"{userInput.Num1} {userInput.Op1} {userInput.Num2} { userInput.Op2 } { userInput.Num3} = { calc.Calculate(userInput)}");

                #region
                //if (userInput.Op1 == "+" && userInput.Op2 == "+")
                //{
                //    double summa = userInput.Num1 + userInput.Num2 + userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "+" && userInput.Op2 == "-")
                //{
                //    double summa = userInput.Num1 + userInput.Num2 - userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "+" && userInput.Op2 == "/")
                //{
                //    double summa = (userInput.Num1 + userInput.Num2) / userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "+" && userInput.Op2 == "*")
                //{
                //    double summa = (userInput.Num1 + userInput.Num2) * userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "*" && userInput.Op2 == "-")
                //{
                //    double summa = userInput.Num1 * userInput.Num2 - userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "*" && userInput.Op2 == "+")
                //{
                //    double summa = userInput.Num1 * userInput.Num2 + userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "*" && userInput.Op2 == "*")
                //{
                //    double summa = userInput.Num1 * userInput.Num2 * userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "*" && userInput.Op2 == "/")
                //{
                //    double summa = (userInput.Num1 * userInput.Num2) / userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "-" && userInput.Op2 == "-")
                //{
                //    double summa = userInput.Num1 - userInput.Num2 - userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "-" && userInput.Op2 == "+")
                //{
                //    double summa = userInput.Num1 - userInput.Num2 + userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "-" && userInput.Op2 == "*")
                //{
                //    double summa = (userInput.Num1 - userInput.Num2) * userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "-" && userInput.Op2 == "/")
                //{
                //    double summa = (userInput.Num1 - userInput.Num2) / userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "/" && userInput.Op2 == "/")
                //{
                //    double summa = userInput.Num1 / userInput.Num2 / userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "/" && userInput.Op2 == "+")
                //{
                //    double summa = (userInput.Num1 / userInput.Num2) + userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "/" && userInput.Op2 == "-")
                //{
                //    double summa = (userInput.Num1 / userInput.Num2) - userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}

                //else if (userInput.Op1 == "/" && userInput.Op2 == "*")
                //{
                //    double summa = (userInput.Num1 / userInput.Num2) * userInput.Num3;
                //    Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);
                //}
                #endregion
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
