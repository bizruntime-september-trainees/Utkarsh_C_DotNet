using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class ListDem
    {

    // Main Method 
    static public void Main()
    {

        //......List is a generic class in Collection
        
        List<int> l1 = new List<int>(); //......Adding Integer values

        // Adding elements to List 
        // Using Add() method 
        l1.Add(1);
        l1.Add(2);
        l1.Add(2);
        l1.Add(17);
        l1.Add(10);
        l1.Add(27);
        l1.Add(35);
            

        // Accessing elements of l1 
        // Using foreach loop 
        foreach (int a in l1)  
        {
            Console.Write(a +" ,");
        }

            Console.WriteLine();
            // Initial count 
            Console.WriteLine("Initial count:{0}", l1.Count);

            //....Using Remove() method

            l1.Remove(17);

            foreach (int a1 in l1) 
            {
                Console.Write(a1+ " ");
             }

           

            l1.RemoveRange(0,2);

            Console.WriteLine("Count after removing elements from 0 to 2: "+l1.Count);

            l1.Clear();

            Console.WriteLine("Count: = "+l1.Count);

            Console.ReadKey();
        }
} 
}
