using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "Utkarsh";

            string guessWord = "";

            bool outOfGuesses = false;
            int guessCount = 0;
            int count = 3;

            do
            {
                if (guessCount < count)
                {

                    Console.Write("Enter guess: ");
                    guessWord = Console.ReadLine();
                    guessCount++;
                }
                else
                    outOfGuesses = true;
            }
            while (guessWord != secret && outOfGuesses != true);

            if(outOfGuesses)
                Console.WriteLine("You lose!!");
            else
                Console.WriteLine("You Win !!");

            Console.ReadKey();
        }
    }
}
