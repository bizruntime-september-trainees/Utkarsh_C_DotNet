using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cube of "+num +" = "+cube(num));

            Console.ReadLine();
        }

        static int cube(int num) {

            return num * num * num;
        }
    }
}
