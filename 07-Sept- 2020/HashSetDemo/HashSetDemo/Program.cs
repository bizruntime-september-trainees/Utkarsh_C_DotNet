using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
   
        //.......HashSet is a generic class of Collection Interface
      

            class GFG
        {

            // Main Method 
            static public void Main()
            {

                // Creating HashSet 
                // Using HashSet class 
                HashSet<string> h1 = new HashSet<string>();

                // Add the elements in HashSet 
                // Using Add method 
                h1.Add("Utkarsh");
                h1.Add("Pant");
                h1.Add("Biz");
                h1.Add("Runtime");
                h1.Add("Visur");
             h1.Add("Roger");


                Console.WriteLine("Elements of hashset 1:");

                // Accessing elements of HashSet 
                // Using foreach loop 

                foreach (var v in h1)
                {
                    Console.Write(v +" , ");
                }

                // Creating another HashSet using Collection initializer
               
                HashSet<int> h2 = new HashSet<int>() {10,
                               6,12,19,0};

                // Display elements of myhash2 
                Console.WriteLine("Elements of hashset 2:");
                foreach (var val in h2)
                {
                    Console.WriteLine(val);
                }

            //.........Removing elements from the set 1

            Console.WriteLine("Initial Count: "+h1.Count());

            h1.Remove("Roger");

            Console.WriteLine("Total number of elements after removing Roger: {0}", h1.Count());


            //......Removing all Elements of Set...

            h1.Clear();

            Console.WriteLine("Elements left after deleting every element of Set:  {0}",h1.Count);
            Console.ReadKey();

            }
        }
    }
    
