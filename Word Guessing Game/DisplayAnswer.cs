using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    public class DisplayAnswer
    {
        public void displayAnswer(char letter, char wW1, char wW2, char wW3, char wW4, char wW5, int sit)
        {
            int answer = 0;
            switch (sit)
            {
                case 1:
                    if (letter == wW1)
                    {
                        answer = 1;
                    }
                    else if (letter == wW2 || letter == wW3 || letter == wW4 || letter == wW5)
                    {
                        answer = 2;
                    }
                    else
                    {
                        answer = 3;
                    }
                    break;

                case 2:
                    if (letter == wW2)
                    {
                        answer = 1;
                    }
                    else if (letter == wW1 || letter == wW3 || letter == wW4 || letter == wW5)
                    {
                        answer = 2;
                    }
                    else
                    {
                        answer = 3;
                    }
                    break;

                case 3:
                    if (letter == wW3)
                    {
                        answer = 1;
                    }
                    else if (letter == wW1 || letter == wW2 || letter == wW4 || letter == wW5)
                    {
                        answer = 2;
                    }
                    else
                    {
                        answer = 3;
                    }
                    break;

                case 4:
                    if (letter == wW4)
                    {
                        answer = 1;
                    }
                    else if (letter == wW1 || letter == wW2 || letter == wW3 || letter == wW5)
                    {
                        answer = 2;
                    }
                    else
                    {
                        answer = 3;
                    }
                    break;

                case 5:
                    if (letter == wW5)
                    {
                        answer = 1;
                    }
                    else if (letter == wW1 || letter == wW2 || letter == wW3 || letter == wW4)
                    {
                        answer = 2;
                    }
                    else
                    {
                        answer = 3;
                    }
                    break;
            }
            switch (answer)
            {
                case 1:
                    Console.WriteLine(letter + ": is correct and in the right place");
                    break;

                case 2:
                    Console.WriteLine(letter + ": is correct but in the wrong place");
                    break;

                case 3:
                    Console.WriteLine(letter + ": is not in the word and is wrong");
                    break;
            }
        }
    }
}
