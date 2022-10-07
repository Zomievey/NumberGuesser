using System;


//Namespace
namespace NumberGuesser
{
    //Main Class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppIfo(); // run the function

            GreetUser(); // greets user and asks name

            //allows player to play again
            while (true)
            {

                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;


                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Please enter a number.");

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess variable
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please guess again.");
                    }
                }


                //Change the text color

                PrintColorMessage(ConsoleColor.Cyan, "You are CORRECT!!!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer and make sure it is uppercase for conditions
                string answer = Console.ReadLine().ToUpper();


                if (answer == "Y")
                {
                    continue;
                }
                if (answer == "N")
                {
                    return;
                }
                else if (answer != "N" || answer != "Y")
                {
                    NewGame(ConsoleColor.Yellow, "To continue press [Y or N]");
                    string answerTwo = Console.ReadLine().ToUpper();
                    if (answerTwo == "Y")
                    {
                        continue;
                    }
                    if (answerTwo == "N")
                    {
                        return;
                    }

                }
            }
        }


        static void GetAppIfo()
        {
            //Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Haylee Hunter";

            //Change the text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}.", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change the text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }

        static void NewGame(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
