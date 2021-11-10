namespace CICDCalculationUppgift
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
            //Displays an animated welcome message and menu
            new Welcome().DisplayMessageAndMenu();
            Console.ReadKey();


                //Double-variable for storing the result of each calculation below. Originally changed from using Integers to allow for the use of decimals. 
                double summa = 0;
                Console.Clear();
                //Creates a new instance of UserInput with no value assigned
                UserInput.UserInput userInput = new();
                //Runs method to ask for user input
                userInput.CheckUserInput();

                if (userInput.Op1 == "+" && userInput.Op2 == "+")
                {
                    summa = userInput.Num1 + userInput.Num2 + userInput.Num3;                    
                }
                else if (userInput.Op1 == "+" && userInput.Op2 == "-")
                {
                    summa = userInput.Num1 + userInput.Num2 - userInput.Num3;
                }
                else if (userInput.Op1 == "+" && userInput.Op2 == "/")
                {
                    summa = userInput.Num1 + userInput.Num2 / userInput.Num3;
                }
                else if (userInput.Op1 == "+" && userInput.Op2 == "*")
                {
                    summa = userInput.Num1 + userInput.Num2 * userInput.Num3;
                }
                else if (userInput.Op1 == "*" && userInput.Op2 == "-")
                {
                    summa = userInput.Num1 * userInput.Num2 - userInput.Num3;
                }
                else if (userInput.Op1 == "*" && userInput.Op2 == "+")
                {
                    summa = userInput.Num1 * userInput.Num2 + userInput.Num3;
                }
                else if (userInput.Op1 == "*" && userInput.Op2 == "*")
                {
                    summa = userInput.Num1 * userInput.Num2 * userInput.Num3;
                }
                else if (userInput.Op1 == "*" && userInput.Op2 == "/")
                {
                    summa = userInput.Num1 * userInput.Num2 / userInput.Num3;
                }
                else if (userInput.Op1 == "-" && userInput.Op2 == "-")
                {
                    summa = userInput.Num1 - userInput.Num2 - userInput.Num3;
                }
                else if (userInput.Op1 == "-" && userInput.Op2 == "+")
                {
                    summa = userInput.Num1 - userInput.Num2 + userInput.Num3;
                }
                else if (userInput.Op1 == "-" && userInput.Op2 == "*")
                {
                    summa = userInput.Num1 - userInput.Num2 * userInput.Num3;
                }
                else if (userInput.Op1 == "-" && userInput.Op2 == "/")
                {
                    summa = userInput.Num1 - userInput.Num2 / userInput.Num3;
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "/")
                {
                    summa = userInput.Num1 / userInput.Num2 / userInput.Num3;
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "+")
                {
                    summa = userInput.Num1 / userInput.Num2 + userInput.Num3;
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "-")
                {
                    summa = userInput.Num1 / userInput.Num2 - userInput.Num3;
                }
                else if (userInput.Op1 == "/" && userInput.Op2 == "*")
                {
                    summa = userInput.Num1 / userInput.Num2 * userInput.Num3;
                }

                //Displays the result of each calculation to the user. Displays the result (double Summa) and each of the user's inputs from the UserInput-class.
                Console.WriteLine(userInput.Num1 + userInput.Op1 + userInput.Num2 + userInput.Op2 + userInput.Num3 + "=" + summa);


                //Possibility to exit program by the end of each cycle by typing "exit"
                Console.WriteLine("To exit write 'exit'.");
                Console.WriteLine("Write 'menu' to go to the menu.");
                Console.WriteLine("Or press 'c' to continue.");
                switch (Console.ReadLine().ToLower())
                {
                    case "exit":
                        run = false;
                        break;

                    case "menu":
                        run = true;
                        break;

                    case "c":
                    default:
                        break;
                }
            }
        }
    }
}