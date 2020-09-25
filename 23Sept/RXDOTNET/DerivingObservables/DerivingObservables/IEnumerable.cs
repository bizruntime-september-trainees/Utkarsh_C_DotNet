using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DerivingObservables
{
    interface IEnumerable<T>
    {

      IEnumerator<T>  GetEnumerator();
    }

    interface IEnumerator<T> {

        //   returns T | void | Exception MoveNext();

        //......Get the next value

            T MoveNext();

        //....bool MoveNext();


        //      T Current {get;}

     

        //.......Error
        Exception MoveNext();

        //......On Completion
        void MoveNext();
        void Dispose();
    
    }
}
