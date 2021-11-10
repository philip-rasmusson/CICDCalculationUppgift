namespace CICDCalculationUppgift
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Welcome
    {
        /// <summary>
        /// Display Calculator and Menu and clear console with a time delay in between
        /// </summary>
        public async void DisplayMessageAndMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ____  ____  _     ____  _     _     ____  _____  ____  ____ ");
            Console.WriteLine(@"/   _\/  _ \/ \   /   _\/ \ /\/ \   /  _ \/__ __\/  _ \/  __\");
            Console.WriteLine(@"|  /  | / \|| |   |  /  | | ||| |   | / \|  / \  | / \||  \/|");
            Console.WriteLine(@"|  \__| |-||| |_/\|  \_ | \_/|| |_/\| |-||  | |  | \_/||    /");
            Console.WriteLine(@"\____/\_/ \|\____/\____/\____/\____/\_/ \|  \_/  \____/\_/\_\");
            await Task.Delay(2000).ConfigureAwait(false);
            Console.Clear();
            Console.WriteLine(" _      _____ _      _    ");
            Console.WriteLine(@"/ \__/|/  __// \  /|/ \ /\");
            Console.WriteLine(@"| |\/|||  \  | |\ ||| | ||");
            Console.WriteLine(@"| |  |||  /_ | | \||| \_/|");
            Console.WriteLine(@"\_/  \|\____\\_/  \|\____/");
            Console.WriteLine();
            Console.WriteLine("Press any key to start");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}