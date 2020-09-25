using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxDotNetDemo
{
    class Observer : IObserver<int>
    {
        //  These methods will be called when Observable has the values to give to Observer
        
        //      3. Write a method that will receive the value from Observable
        public void OnNext(int value) {

            var threadID = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($" Value received on Thread {threadID}: {value}");
        }
        public void OnError(Exception error) {
            var threadID = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Error Reported on Thread {threadID}: {error.Message}");
        }

        public void OnCompleted() {

            var threadID = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Observation completed on Thread {threadID}");
        }
    }
}
