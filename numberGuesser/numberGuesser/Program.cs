using System;

// Namespace
namespace numberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //run get app info
            getAppInfo();

            //Ask for users name and greet
            greetUser();

            while (true)
            {

                //Create a new random object;
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is incorrect
                while (guess != correctNumber)
                {

                    //get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        //Print error message
                        printColorMessage(ConsoleColor.Red, "Please use a number");

                        //Keep going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {

                        //Not the correct number
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                printColorMessage(ConsoleColor.Yellow, "Correct number!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else {
                    return;
                }
            }

        }

        static void getAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "John Economou";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void greetUser() {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        static void printColorMessage(ConsoleColor color, string message) {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}

