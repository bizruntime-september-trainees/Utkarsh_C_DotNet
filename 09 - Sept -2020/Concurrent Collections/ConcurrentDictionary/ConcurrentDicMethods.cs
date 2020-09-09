
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

ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
    dictionary.TryAdd("1", "First");
    dictionary.TryAdd("2", "Second");
    dictionary.TryAdd("3", "Third"); //.....returns false
    dictionary.TryAdd("4", "Fourth");
 
    foreach(var item in dictionary)
    {
        Console.WriteLine(item.Key + "-" + item.Value);
    }
	
	 bool isItemExists1 = dict.TryGetValue("1", out itemValue1);  //returns true
    Console.WriteLine(itemValue1); 
 
    bool isItemExists2 = dict.TryGetValue("3", out itemValue2);  //returns false
    Console.WriteLine(itemValue2); //Print 
	
	//.......Removing item
	 string removedItem;
    bool result = dictionary.TryRemove("2", out removedItem); //Returns true
    Console.WriteLine(removedItem); //Print "Second"
	
	//........Checking whether key contains or not
	
	bool firstItem = dictionary.ContainsKey("1"); 
    bool fifthItem = dictionary.ContainsKey("5"); 
}
	}
