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
	ConcurrentBag<int> bag = new ConcurrentBag<int>();
 
    Task t1 = Task.Factory.StartNew(() =>
        {
            for (int i = 1; i < 10; ++i)
            {
                bag.Add(i);
                Thread.Sleep(200);
            }
        });
 
    Task t2 = Task.Factory.StartNew(() =>
        {
            int i = 0;
            while (i != 4)
            {
                foreach (var item in bag)
                {
                    Console.WriteLine(i + "-" + item);
                    Thread.Sleep(200);
                }
                i++;
                Thread.Sleep(200);
            }
 
	
}

	}