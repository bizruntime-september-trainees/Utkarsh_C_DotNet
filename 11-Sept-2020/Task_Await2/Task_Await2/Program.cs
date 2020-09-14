using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Await2
{

    //......Task2 dependent on Task1 but Task2 does not depend on Task 1
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }

        static void Calculate()
        {

            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });

            var awaiter1 = task1.GetAwaiter(); //......Waiting for first task to complete
            awaiter1.OnCompleted(() =>
            {
                var result1 = awaiter1.GetResult();
                Calculate2(result1);  //....Call back function inside Lambda Expression
            });

            Calculate3();
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


