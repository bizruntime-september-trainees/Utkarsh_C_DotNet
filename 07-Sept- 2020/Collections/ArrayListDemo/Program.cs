

namespace ArrayListDemo
{

	using System;
	using System.Collections;



	class Program
	{

		// Main Method 
		static public void Main()
		{

			// Creating ArrayList object
			ArrayList My_array = new ArrayList();


			My_array.Add(12.56); //..float/double
			My_array.Add("Utkarsh"); //.....String
			My_array.Add(null);//.......null
			My_array.Add('G'); //.......char
			My_array.Add(1234); //........Integer


			//.....Iterating arrayList elements
			foreach (var elements in My_array)
			{
				Console.WriteLine(elements);
			}
		}
	}
}
