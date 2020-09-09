using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace LinqMethod
{  
class Program  
    {  
static void Main(string[] args)  
        {  
//Data Source  
            List<int>integerList = new List<int>()  
            {  
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10  
            };  
//LINQ Query using Method Syntax  
var MethodSyntax = integerList.Where(obj =>obj> 5).ToList();   //....datsource.ConditonMethod().SelectionMethod()
//Execution  
foreach (var item in MethodSyntax)  
            {  
Console.Write(item + " ");  
            }  
  
 
        }  
    }  
}  