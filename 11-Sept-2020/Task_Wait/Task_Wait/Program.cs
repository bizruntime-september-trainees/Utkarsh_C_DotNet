using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Waiting_Task
{

    //.......Calculation3 depends on Calculation1 and Calculation2
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }

        static void Calculate()
        {

           var task1= Task.Run(() =>
            {
               return Calculate1();
            });

            var task2 = Task.Run(() =>
            {
               return Calculate2();
            });

            Task.WaitAll(task1, task2); //........Waiting for task1 and task2 to complete

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();

            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate3(result1 , result2);
        }

        static int Calculate1()
        {
            Console.WriteLine("Calculating Result 1");
            Thread.Sleep(5000); //......Task1 starts first but will finish second
            return 100;
        }

        static int Calculate2()
        {
            Console.WriteLine("Calculating Result 2");
            return 200;
        }

        static int Calculate3(int result1, int result2)
        {

            Console.WriteLine("Calculating Result 3");
            return result1 + result2;
        }


    }
}
