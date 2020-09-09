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
	
	
	
	List<int> ints = new List<int>();
ints.Add(1);
ints.Add(2);
ints.Add(3);
ints.Add(4);

ConcurrentBag<int> bag = new ConcurrentBag<int>(ints);
 

int count = bag.Count; //returns 
	
	
	//.....Adding new items
	
	bag.Add(5);
	bag.Add(6);
	
	//.....Adding multiple items
	
	int[] arr = {7,8,9};
	
	foreach(var item in arr){
		
		bag.Add(item);
	}
	
	//.......Retrieving items........
	
	int item;
bool isSucess = bag.TryPeek(out item);

isSucess = bag.TryPeek(out item);

bool isSucess1 = bag.TryTake(out item);

isSucess1 = bag.TryTake(out item);
	
	
	
}
	
}
	