using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{

    //......Task2 dependent on Task1 but Task2 does not depend on Task 1
    class Program
    {
        static void Main(string[] args)
        {
            Test(); //......1)
            Console.ReadKey();
        }

        async static void Test() {

            await Calculate();  //.......2)
        }
       async static Task Calculate()
        {
            await Calculate1_2();  //......3)

            Calculate3(); //............7
        }

        async static Task Calculate1_2() {

           var result1 = await Task.Run(() =>
            {

                return Calculate1(); //..........4

            }); 

            Calculate2(result1);   //.........5
        }

        static int Calculate1()
        {
            Console.WriteLine("Calculating Result 1");
            Thread.Sleep(5000); //......Task1 starts first but will finish second
            return 100;
        }

        static int Calculate2(int result1)
        {
            Console.WriteLine("Calculating Result 2");
            return result1 * 2;
        }

        static int Calculate3()
        {

            Console.WriteLine("Calculating Result 3");
            return 300;
        }
    }
}


