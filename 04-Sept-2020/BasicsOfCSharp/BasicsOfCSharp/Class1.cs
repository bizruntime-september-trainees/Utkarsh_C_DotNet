using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class GuessGame
    {

        public static void Main(string[] args) {

            string secret = "Utkarsh";

            string guess = "";

            int guessCount = 0;
            int count = 3;
            bool outOfGuesses = false;

            while (guess != secret && outOfGuesses ==false)
            {

                if (guessCount < count)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                    outOfGuesses = true;
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You Lose !!");
            }
            else
                Console.WriteLine("You Won");

            Console.ReadKey();
        }
    }
}
