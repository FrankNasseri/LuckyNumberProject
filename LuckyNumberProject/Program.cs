using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //PART ONE
                // Ask the user for a starting number for the lowest number in the number range.
                Console.WriteLine("Please insert a starting number low number, higher than zero");
                int firstNumber = int.Parse(Console.ReadLine());
                //Ask the user for an ending number for the highest number in the number range.
                Console.WriteLine("Please insert an ending number for the highest number in the number range");
                int secondNumber = int.Parse(Console.ReadLine());
                //Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
                // Numbers must be stored in an array
                // Array must be populated using a loop
                //If the user enters a number that is outside of the range set, prompt the user to give you a valid number. 
                //Do this until the user enters a valid number.
                int jackPot = 125000;
                int[] userGuess = new int[6];
                for (int i = 0; i <= userGuess.Length - 1; i++)
                {
                    Console.WriteLine("Guess a number:");
                    userGuess[i] = int.Parse(Console.ReadLine());

                    //This while loop is acting as a conditional
                    while (userGuess[i] < firstNumber || userGuess[i] > secondNumber)
                    {
                        Console.WriteLine("Please insert a number between" + " " + firstNumber + " - " + secondNumber);
                        break;
                    }
                }

                //PART TWO
                //the program should randomly generate 6 numbers using a loop
                Random randomNumber = new Random();
                int[] winningNumber = new int[6];
                for (int i = 0; i <= winningNumber.Length - 1; i++)
                {
                    winningNumber[i] = randomNumber.Next(firstNumber, secondNumber);
                }
                foreach (int number in winningNumber)
                {
                    Console.WriteLine("The Winning Numbers are: " + (number));
                }

                //PART 3
                //Hard-code a value for the jackpot amount and let the user know what the jackpot amount is at some.. 
                //..point you decide in the program. (at the beginning)
                //The program should count the number of correctly guessed numbers and output to..
                //..the console to notify the user. 
                int rightNumber = 0;
                for (int i = 0; i < userGuess.Length; i++)
                {
                    foreach (int number in winningNumber)
                    {
                        if (number == userGuess[i])

                        {
                            rightNumber += 1;
                        }
                    }
                }
                Console.WriteLine("You guessed" + " " + rightNumber + " " + "numbers correctly!");
                if (rightNumber == 6)
                {
                    Console.WriteLine("Congrats, you guessed all the numbers right!");
                    Console.WriteLine("You won" + " " + "$" + jackPot);
                }
                else if (rightNumber == 5)
                {
                    Console.WriteLine("Congrats, you guessed five numbers right! ");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * .8));
                }
                else if (rightNumber == 4)
                {
                    Console.WriteLine("Congrats, you guessed four numbers right! ");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * .6));
                }
                else if (rightNumber == 3)
                {
                    Console.WriteLine("Congrats, you guessed three numbers right! ");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * .4));
                }
                else if (rightNumber == 2)
                {
                    Console.WriteLine("Congrats, you guessed two numbers right! ");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * .2));
                }
                else if (rightNumber == 1)
                {
                    Console.WriteLine("Congrats, you guessed one number right! ");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * .1));
                }
                else
                {
                    Console.WriteLine("Next time try harder! You get nothing!");
                    Console.WriteLine("You won" + " " + "$" + (jackPot * 0));
                }
                while (true)
                    //asking the user if they want to play again using while loops
                {
                    Console.WriteLine("Would you like to play again? (yes/no)");
                    string userOption = Console.ReadLine();
                    if (userOption == "yes")
                        break;
                    if (userOption == "no")
                        Console.WriteLine("Thanks for playing!");
                        return;
                }
            }

        }
    }
}
