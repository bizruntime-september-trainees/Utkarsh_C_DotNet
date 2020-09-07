using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating SortedSet 
            // Using SortedSet class 
            SortedSet<int> s1 = new SortedSet<int>();

            // Add the elements in SortedSet 
            // Using Add method 
            s1.Add(12);
            s1.Add(0);
            s1.Add(8);
            s1.Add(7);
            Console.WriteLine("Elements of s1:");

            // Accessing elements of SortedSet 
            // Using foreach loop 
            foreach (var v in s1)
            {
                Console.Write(v+" , ");
            }

            Console.WriteLine();

            Console.WriteLine("Total number of elements " +
              "present in my_Set:{0}", s1.Count);

            //......Checking Availability......

            Console.WriteLine("7 is present in the set: "+s1.Contains(7));

            s1.Remove(7);

           

            // Before using Remove method 
            Console.WriteLine("Total number of elements " +
                   "present in my_Set:{0}", s1.Count);

            Console.WriteLine("7 is present in the set: "+s1.Contains(7));

            // Creating another SortedSet 

            SortedSet<int> h2 = new SortedSet<int>() {
                                5,87,34,1,90};

            // Display elements of h2 
            Console.WriteLine("Elements of h2:");
            foreach (var v in h2)
            {
                Console.Write(v +" ,");
            }

            Console.ReadKey();
        }
    }
}
