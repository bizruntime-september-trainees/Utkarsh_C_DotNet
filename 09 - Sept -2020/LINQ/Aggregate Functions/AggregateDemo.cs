using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace AggregateDemo{
class Program  
    {  
static void Main(string[] args)  
        {  
//Data Source  
            List<int>integerList = new List<int>()  
            {  
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10  
            };  
			
//LINQ Query using Query Syntax  
var QuerySyntax = from obj in integerList  //.......Initialization
where obj> 5   //......Conditon
select obj;//.....Selection

//Execution   
foreach (var item in QuerySyntax)  
{  
Console.Write(item +" ");  
            }  
			
			//...........Aggregate Funcitons

		
			int minimumNumber = integerList.Min(); //......Minimum Function
			Console.WriteLine("Minimum number in the list: {0}", minimumNumber);
			
			int maximumNumber = integerList.Max(); //....Maximum function
			Console.WriteLine("Maximum number in the list: {0}", maximumNumber);
			
			int sum = integerList.Sum(); //......Summation
			Console.WriteLine("Sum of all elements in the list: {0}", sum);
			
			 
			
			
			int count = integerList.Count();
			Console.WriteLine("Total elements in the list: {0}", count); //.....Count of all elements
			
			//.........Aggregate Function......is used to perform operation on every item in the list
			
			double product = integerList.Aggregate((a, b) => a * b);  
			
			Console.WriteLine("Product of all elements : {0}", product);
			
			string[] s1 = new string(){"a", "b", "c", "d"};
			
			var concat = s1.Aggregate((a,b) => a +" , "+b));
			
			Console.WriteLine(concat +" ");
			
Console.ReadKey();  
        }  
    }  
}
