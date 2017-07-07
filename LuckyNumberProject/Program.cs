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
            int[] userGuess = new int[6];
            for (int i = 0; i <= userGuess.Length - 1; i++)
            {
                Console.WriteLine("Guess a number:");
                userGuess[i] = int.Parse(Console.ReadLine());

                while (userGuess[i] > firstNumber && userGuess[i] < secondNumber)
                {
                    userGuess[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Please insert a number between" + " " + firstNumber + " - " + secondNumber);
            }
            //PART TWO
            //the program should randomly generate 6 numbers using a loop




            


        }
    }
}
