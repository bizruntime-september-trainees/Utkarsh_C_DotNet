using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // create and initalize Hash table 
            // using Add() method 
            Hashtable g = new Hashtable();
            g.Add(1, "hello");
            g.Add(2, "there");
            g.Add(3, "How");
            g.Add(4, "are");
            g.Add(5, "You");

            ICollection key = g.Keys;

            // Print Hash table 
            Console.WriteLine("Hashtable:");
            Console.WriteLine();
            foreach (var val in key)
            {
                Console.WriteLine(val + "-" + g[val]);
            }
        }
    }
}
