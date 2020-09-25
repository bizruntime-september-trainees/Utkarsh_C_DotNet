using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCreate
{
    class Program
    {
        static void Main(string[] args)
        {

            // Step1:  Create an Observable using one of the parameters on System.Reactive.Linq.Observable class

            var observable = Observable.Range(10, 7); //......Obtaining instance of class that implements IObservable<T>

            

            IObserver<int> observer = Observer.Create<int>(
                //  Step3: Receive a value from the observable

                Console.WriteLine, //  OnNext Handler
                (error) => { Console.WriteLine($"Error: {error.Message}"); },  //    On error handler
                () => { Console.WriteLine("Observation Complete !!"); } //  OnCompleted Handler 
                );


            var subscription = observable.Subscribe(observer);


            //  4. Dispose off the subscription when you're done observing......

            subscription.Dispose();

            Console.ReadKey();

        }
    }
    
}
