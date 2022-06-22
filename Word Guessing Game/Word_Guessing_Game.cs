using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    public class Word_Guessing_Game
    {

        public static void Main(string[] args)
        {
            Random random = new Random();
            int dictionaryNumber = random.Next(0, 411);

            string winningWord = FiveLetterDictionary.fiveLetterWords(dictionaryNumber);
            string wW = winningWord.ToLower();

            char wW1 = wW[0];
            char wW2 = wW[1];
            char wW3 = wW[2];
            char wW4 = wW[3];
            char wW5 = wW[4];
            
            bool numberOfTries = false;

            do
            {
                Console.WriteLine("What is your guess:");
                string guessingWord = Console.ReadLine();
                string gW = guessingWord.ToLower();
                
                int sit = 1;

                foreach (char i in guessingWord)
                {
                    DisplayAnswer dA = new DisplayAnswer();
                    dA.displayAnswer(i, wW1, wW2, wW3, wW4, wW5, sit);
                    sit++;
                }
                
                if (gW == wW)
                {
                    numberOfTries = true;
                }
            }
            while (numberOfTries == false);
        }
    }
}

