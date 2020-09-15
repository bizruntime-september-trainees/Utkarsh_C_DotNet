using System;


namespace Calculator
{
    public class Calculate
    {
        public static int Divide(int num, int den) {

            int result = num / den;

            return result;
        
        }

        public static void Main(string[] args) {


           
            Divide(10,2);
            Console.ReadKey();

        }

    }
}
