using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxUsingSubjectofT
{

    //      Creating Observable instance using Subject<T> class that implements both IObservable and IObserver interface
    class Program
    {
        static void Main(string[] args)
        {

            Demo();
            Console.ReadKey();
        }

        static void Demo() {

            //      Creating instance of Subject<T> class

            var subject = new Subject<string>();

            //var subscription = subject.Subscribe(Console.WriteLine);    // For value handler

            //subject.OnNext(1);
            //subject.OnNext(2);

            //subscription.Dispose();

            //subject.OnNext(3);

            // Creating Observable instance using Enumerator 

            var o1 = new[] { "Hello", "World" }.ToObservable();

            //      Subject itself subscribes to or gets values from IEnumberable of Strings

            var s4 = o1.Subscribe(subject);

            var s1 = subject.Subscribe(v => Program.PrintToConsole("Sub 1",v));


        }
    }
}
