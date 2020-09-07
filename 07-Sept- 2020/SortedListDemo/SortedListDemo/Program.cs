using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortedListDemo
{
    class Program

        //......SortedList stores the object in key-value pairs...
    {
        static void Main(string[] args)
        {

            SortedList sh = new SortedList();

            // Adding elements to SortedList 
            sh.Add(1, 1.0);
            sh.Add(3, "3rd ");
            sh.Add(1, "1st ");
            sh.Add(2, "2nd ");
            sh.Add(4, "4th");
            sh.Add(5, "5th");
            sh.Add(7, "7th");

            foreach (DictionaryEntry pair in sh) {
                Console.WriteLine(pair.Key +" "+pair.Value);
            }

            // Displaying number of elements 
            Console.WriteLine("Number of elements in SortedList is : "
                              + sh.Count);

            // Displaying capacity 
            Console.WriteLine("capacity of SortedList is : "
                              + sh.Capacity);

            // Removing all elements from SortedList 
            sh.Clear();

            // Displaying number of elements 
            Console.WriteLine("Number of elements in SortedList is : "
                              + sh.Count);

            // Displaying capacity 
            Console.WriteLine("capacity of SortedList is : "
                              + sh.Capacity);

            Console.ReadKey();
        }
    }
}
