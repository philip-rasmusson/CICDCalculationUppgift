namespace CICDCalculationUppgift
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            //Displays an animated welcome message and menu
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

                //Possibility to exit program by the end of each cycle by typing "exit"
                Console.WriteLine("To exit write 'exit', try again by pressing enter");
                switch (Console.ReadLine().ToLower())
                {
                    case "exit":
                        run = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}