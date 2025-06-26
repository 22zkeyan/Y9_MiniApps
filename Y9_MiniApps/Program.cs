using System;
using System.Timers;

namespace Y9_MiniApps
{
    internal class Program
    {
        static void MainMenu()
        {
            bool keep_going = true;
            while (keep_going)
            {
                Console.WriteLine("Menu options: " +
                    "\n1. Times tables quiz" + 
                    "\n2. Shapes area calculator" +
                    "\n3. Exit app");
                Console.Write("Enter the number of the option you want: ");
                int menu_option = Convert.ToInt32(Console.ReadLine()!); //takes an input from the user and converts it to an integer
                switch (menu_option)
                {
                    case 1:
                        Console.WriteLine("Loading Times table game...\n");
                        Thread.Sleep(3000);
                        TimesTableGame();
                        keep_going = false;
                        break;
                    case 2:
                        Console.WriteLine("Loading Shapes area calc...\n");
                        Thread.Sleep(3000);
                        ShapesAreaCalc();
                        keep_going = false;
                        break;
                    case 3:
                        Console.WriteLine("Exiting app...");
                        Thread.Sleep(2000);
                        keep_going = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.\n");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
        static System.Timers.Timer? timer;
        static int secondsLeft = 60;
        static void TimesTableGame()
        {
            //setting up numbers
            Random r = new Random();
            int num1 = r.Next(1, 11);
            int num2 = r.Next(1, 11);
            int sum = num1 * num2;

            timer = new System.Timers.Timer(1000); // Fully qualified name
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.WriteLine();
        }
        static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            secondsLeft--;
            Console.WriteLine($"Time left: {secondsLeft} seconds");

            if (secondsLeft <= 0)
            {
                Console.WriteLine("Time's up!");
                timer?.Stop();
                // Optionally exit or reset the game here
            }
        }
        static void ShapesAreaCalc()
        {
            Console.WriteLine("What shape do you want? Options: " +
                "\n- Square" + 
                "\n- Rectangle" + 
                "\n- Triangle" + 
                "\n- Trapezium" + 
                "\n- BONUS cuboid surface area");
            string input = Console.ReadLine()!;

        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}