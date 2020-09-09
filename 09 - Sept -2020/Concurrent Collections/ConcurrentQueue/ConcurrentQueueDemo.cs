

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
 
ConcurrentQueue<int> coll = new ConcurrentQueue<int>(ints);

coll.Enqueue(3);
coll.Enqueue(4);
coll.Enqueue(5);
coll.Enqueue(6);
		  
		  //.........Retriving all items from Queue
		  
		  foreach (var col in coll){
    Console.WriteLine(col);
}

//........Retrive or Remove single item.......

int item;
bool isSuccessful = coll.TryPeek(out item); //.......passing item as reference type using 'out ' keyword

Console.WriteLine(isSuccessful);

Console.WriteLine(item);

//......Dequeing items from queue

isSuccessful = coll.TryDequeue(out item);  
Console.WriteLine(isSuccessful); //Returns True
Console.WriteLine(item);    //Return "1"

Console.WriteLine();

//..........Counting items.......

int count = coll.Count();

//.........Copying ConcurrentQueue to Array......

int[] array = coll.ToArray();
foreach(int i in array)
{
    Console.Write(i +" ,");
}

Console.WriteLine();

}

	}