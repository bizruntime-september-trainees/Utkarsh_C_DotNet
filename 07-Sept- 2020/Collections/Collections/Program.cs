

namespace Collections
{
	
	using System;
	using System.Collections.Generic;

	class ListDemo
	{

		
		public static void Main(String[] args)
		{

			// Creating a List of integers 
			List<int> mylist = new List<int>();

			// adding items in mylist using Add() method
			for (int i = 5; i < 10; i++)
			{
				mylist.Add(i * 3);
			}

			
			foreach (int items in mylist)
			{
				Console.WriteLine(items); //...Printing List items
			}
			Console.ReadKey();
		}
	}

}
