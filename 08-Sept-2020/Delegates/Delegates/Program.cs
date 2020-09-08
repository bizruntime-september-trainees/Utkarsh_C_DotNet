using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    //......A delegate is a function pointer and it is type safe

    public delegate void HelloFunctionDelegate(string message);

    //....This Delegate can call any function with 'void' return type and string argument

    class Program
    {
        static void Main(string[] args)
        {

            HelloFunctionDelegate dl = new HelloFunctionDelegate(Hello);

            dl("Hello method called by Delegate ");

            dl("Hello from Delegate !!..... "); /*
                                                 Delegate will internally call Hello method

                                                 */

            Console.ReadKey();
        }

        static void Hello(string message) {

            Console.WriteLine(message);
        }
    }
}
