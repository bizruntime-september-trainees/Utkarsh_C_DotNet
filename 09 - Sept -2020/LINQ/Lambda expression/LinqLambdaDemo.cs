using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace LinqLambdaDemo 
{  
    public class Program  
    {  
        public static void Main(string[] args)  
        {  
//list to store the countries type of string  
            List<string> countries = new List<string>();  
  
            countries.Add("India");  
  
            countries.Add("Pakistan");  
  
            countries.Add("Australia");  
  
            countries.Add("UK");

			countries.Add("China");
			
    //use lambda expression to show the list of the countries  
	
            IEnumerable<string> result = countries.Select(x => x);  //....countries = Data Source, 
    //foreach loop to display the countries  
            foreach (var item in result)   
  
            {  
                Console.Write(item +" "); 
				Console.WriteLine();
  
            }  
  
            Console.ReadKey();  
        }  
    }  
}  