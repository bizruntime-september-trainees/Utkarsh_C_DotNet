using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            do
            {
                Console.Write("Enter first number: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter operation");

                if (op == "+")
                {

                    Console.WriteLine(num1 + num2);
                }

                else if (op == "-")
                {

                    Console.WriteLine(num1 - num2);
                }
                else if (op == "x")
                {

                    Console.WriteLine(num1 * num2);
                }

                else if (op == "/")
                {

                    Console.WriteLine(num1 / num2);
                }
                else
                    Console.WriteLine("Invalid operator");

                Console.ReadLine();

            }

            while (op == "0");
        }
    }
}
