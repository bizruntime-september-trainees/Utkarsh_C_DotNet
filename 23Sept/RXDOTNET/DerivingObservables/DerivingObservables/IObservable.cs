using System;
using System.Collections.Generic;
using System.Text;

namespace DerivingObservables
{
    interface IObservable<T>
    {
        //......Dual of IObserver
        void Subscribe(IObserver<T>);
    }

    interface IObserver<T>
    {

        //.......Dualizing all 3 methods.......


        //      We have a value
        void OnNext(T Value);

        //      We have an error
        void OnError(Exception e);

        //........OnCompletion

        void OnCompleted();

    }
}
 