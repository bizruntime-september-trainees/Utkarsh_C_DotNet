
//...
 
using System;
using System.Collections;

class ALDemo
{

	
	static public void Main()
	{

		// Creating ArrayList 
		ArrayList al = new ArrayList();

		// Adding elements in the 
		// My_array ArrayList 
		// This ArrayList contains elements 
		// of different types 
			al.Add(4.2);
		al.Add("Utkarsh Pant");
		
		al.Add('h');
		al.Add(null);
		al.Add(27733);
		al.Add("Harry");
		al.Add("Roger");
		al.Add("Rafa");
		al.Add(54);
		al.Add('R');

        

		//.....Accessing every elements in the list.........
		foreach (var elements in al)
		{
			Console.WriteLine(elements);
		}

		Console.WriteLine();

		//.........Checking capacity and count using Count and Capacity Property......

		Console.WriteLine("No of elements in the list: {0}" ,al.Count);

        Console.WriteLine("Default capacity of  Arraylist: {0}", al.Capacity);



        //.......Removing elements in Arraylist using Remove() method.....

        Console.WriteLine("Initial number of elements: " +al.Count);

		al.Remove("Utkarsh Pant");

        Console.WriteLine();

        Console.WriteLine("Total elements after removing Utkarsh: "+al.Count);
		
		//......Removing third element index
		al.RemoveAt(3);

        Console.WriteLine("Total elements left after removing third element");

		//.....Removing 3 elements starting from index 2
		al.RemoveRange(2,4);

		Console.WriteLine();

		Console.WriteLine("Total elements Left : " + al.Count);

		//........Removing All elements of ArrayList



		al.Clear();

        Console.WriteLine("Total Elements Left: "+al.Count);


		Console.ReadKey();
	}
}
