using System;
namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string inputNum = Console.ReadLine();
                    if (!int.TryParse(inputNum, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number!");
                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red,"Wrong number, Please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow,"YOU ARE CORRECT!!");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y"){
                    continue;
                }else if(answer == "N"){
                    return;
                }else
                {
                    return;
                }
            }
        }
        static void GetAppInfo(){
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Yashu";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor();
        }

        static void GreetUser(){
            Console.WriteLine("Enter your Name");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hello {inputName}, Let's play a game...");
        }

        static void PrintColorMessage(ConsoleColor color , String message){
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
        }
    }
}