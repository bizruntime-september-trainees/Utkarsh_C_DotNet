using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Collections.Concurrent;
using System.Linq;
	
   public  class Program
    {  
      public static void Main(string[] args) 
        
{
	
	BlockingCollection<int> bCollection = new BlockingCollection<int>(new ConcurrentBag<int>(), 2);
	
	//.......Adding items to blockingCollection
	
	bCollection.Add(1);
	bCollection.Add(2);
 
	if (bCollection.TryAdd(3, TimeSpan.FromSeconds(1))) //.....When third item is added , it will wait for 1 second
		{
    Console.WriteLine("Item added");
		}
		else
		{
    Console.WriteLine("Item does not added");
		}
		
		//.......Retriving items
		int item = bCollection.Take();
Console.WriteLine(item); //returns 1
	
}

	}