using System;  
using System. Collections;  
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program
    {  
        static void Main(string[] args)  
        {  
//create array count1 and count2 of type string  
            string[] count1 = { "India", "USA", "UK", "Australia" };  
            string[] count2 = { "India", "Canada", "UK", "China" };  
//count1.Union(count2) is used to find out the unique element from both the collection  

            var result = count1.Union(count2);  
//foreach loop is used to print the output conaining in the result  
            foreach (var item in result)  
            {  
                Console.Write(item +" ");  
            }  
                Console.WriteLine();  
				
				
				//........Interset operation
				 var result = count1.Intersect(count2);  
  
            foreach (var item in result)  
            {  
/*Console.WriteLine(item) print  
all element store in the item variable.*/  
                Console.Write(item +" ");  
            }  
			Console.WriteLine();
			
			string[] countries = { "UK", "India", "Australia", "uk", "india", "USA" };  
			
			  IEnumerable<string> result = countries.Distinct(StringComparer.OrdinalIgnoreCase);  
			  
			   foreach (var item in result)  
            {  
			Console.Write(item +" ");
			}
			
			Console.WriteLine();
        }  
    }  
}  