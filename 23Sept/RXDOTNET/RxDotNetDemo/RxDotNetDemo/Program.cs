using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxDotNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //      1. Create the Observable        ......

            var threadID = Thread.CurrentThread.ManagedThreadId.ToString();

            Console.WriteLine("Program started on main method with Thread ID : "+threadID);

            var observable = Observable.Range(10, 5);

            //      2. Subscribe to the observable

            //..Subscribe() takes instance of class that implements IObserver<T>
            var subscription = observable.Subscribe( new Observer());

            Console.ReadKey();
            //    4.  Dispose the subscription when you do not want it anymore

            subscription.Dispose();
        }
    }
}
