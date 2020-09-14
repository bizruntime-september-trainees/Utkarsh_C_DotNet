using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }

        static void Calculate() {

            Task.Run(() =>
            {
                Calculate1();
            });

            Task.Run(() =>
            {
                Calculate2();
            });

            Task.Run(() =>
            {
                Calculate3();
            });
        }

        static int Calculate1() {
            Console.WriteLine("Calculating Result 1");
            Thread.Sleep(3000);
            return 100;
        }

        static int Calculate2() {
            Console.WriteLine("Calculating Result 2");
            return 200;
        }

        static int Calculate3()
        {

            Console.WriteLine("Calculating Result 3");
            return 300;
        }


    }
}
