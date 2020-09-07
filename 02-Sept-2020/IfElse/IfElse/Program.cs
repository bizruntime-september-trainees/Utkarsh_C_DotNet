using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You're a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            }

            else if (!isMale && isTall) {
                Console.WriteLine("You're a tall girl");
            }

            else
                Console.WriteLine("You're a short girl");

            Console.ReadLine();

        }
    }
}
