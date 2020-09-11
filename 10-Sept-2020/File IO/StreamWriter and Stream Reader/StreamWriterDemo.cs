using System;  
using System.IO;  
public class StreamWriterDemo
{  
    public static void Main(string[] args)  
    {  
        FileStream f = new FileStream("e:\\output.txt", FileMode.Create);   //.....creating file stream
		
        StreamWriter s = new StreamWriter(f);   //...Used to write characters to stream
  
        s.WriteLine("hello c#");  
        s.Close();  
        f.Close();  
     Console.WriteLine("File created successfully...");  
    }  
}  