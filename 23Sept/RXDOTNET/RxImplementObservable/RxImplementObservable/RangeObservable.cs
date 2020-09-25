using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxImplementObservable
{
    class RangeObservable : IObservable<int>
    {
        private int start;
        private int count;
        public RangeObservable(int start, int count)
        {

            this.start = start;
            this.count = count;
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {

            for (int i = start; i < start + count; i++)
            {
                observer.OnNext(i);

            }
            observer.OnCompleted();

        }
    }

}
