using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My name" + " is Utkarsh Pant");

            string phrase = "This is a great place";


            //......       Methods of String in C#.............

            Console.WriteLine(phrase.Length);

            Console.WriteLine(phrase[8]);


            Console.WriteLine(phrase.ToUpper());

            Console.WriteLine(phrase.ToLower());

            Console.WriteLine(phrase.Contains("great"));

            Console.WriteLine();

            Console.WriteLine(phrase.Substring(6)); //..Will print all characters from 6th index onwards

            Console.WriteLine(phrase.IndexOf('g')); //...If not present returns -1


            Console.WriteLine(phrase.IndexOf('z'));

            


            //..........Taking input from user..........


            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello "+name);

            //.....Conversion of one datatype to another......

           int number =  Convert.ToInt32("56");

            Console.WriteLine(34 + number);

            //......Taking numbers from User.......

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum of "+num1 +" and "+num2 +" = "+(num1 + num2));

            //........Arrays in C#........

            int[] numbers = new int[6];

            numbers[0] = 3;
            numbers[1] = 9;

            int num = numbers.Length;
            Console.WriteLine(num);

        
          

            Console.ReadLine();


        }
    }
}
