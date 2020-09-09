using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Collections.Concurrent;
using System.Linq;
	
   public  class Program
    {  
	static void Main(string[] args)
{
    BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 10);
 
    Task producerThread = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 10; ++i)
            {
                bCollection.Add(i);
            }
 
            bCollection.CompleteAdding(); //.......Adding items finished
        });
 
    Task consumerThread = Task.Factory.StartNew(() =>
        {
            while (!bCollection.IsCompleted) //.......Returns true when BlockingCollection is empty
            {
                int item = bCollection.Take();
                Console.WriteLine(item);
            }
		}
}
	}
	}