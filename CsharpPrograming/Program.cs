using System;

namespace CsharpPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                //int correctNum = 7;
                Random random = new Random();

                int correctNum = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("guess a number between 1 and 10");

                while (guess != correctNum)
                {
                    string input1 = Console.ReadLine();
                    if (!int.TryParse(input1, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }
                    guess = Int32.Parse(input1);
                    if (guess != correctNum)
                    {
                        

                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");

                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Correct good job!");

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = ("number guesser");
            string appVersion = ("1.0.0");
            string appAuthor = ("Adrian Moor");

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello! {0}, lets play a little game", input);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
