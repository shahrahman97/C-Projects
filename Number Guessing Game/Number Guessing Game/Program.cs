using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    public class Number_Guessing_Game
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int winningNumber = randomNumber.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 & 100");
                string guessedNumber = Console.ReadLine();

                int intGuessedNumber = int.Parse(guessedNumber);

                if (intGuessedNumber < winningNumber)
                {
                    Console.WriteLine("Your number is too low, try again");
                }

                else if (intGuessedNumber > winningNumber)
                {
                    Console.WriteLine("Your number is too high, try again");
                }

                else if (intGuessedNumber == winningNumber)
                {
                    Console.WriteLine("CONGRATS");
                    win = true;
                }
            }

            while (win == false);

            Console.WriteLine("Thanks for playing");
            Console.Write("Type any key to close");
            Console.ReadKey(true);
        }
    }
}