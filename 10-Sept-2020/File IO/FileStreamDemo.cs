using System;  
using System.IO;  
public class FileStreamDemo
{  
    public static void Main(string[] args)  
    {  
	
	//......Writing data into the file
        FileStream f = new FileStream("e:\\abc.txt", FileMode.OpenOrCreate);  
        for (int i = 65; i <= 90; i++)  
        {  
            f.WriteByte((byte)i);  //.......Writing data into file one by one
        }  
      
		
		f.Close(); 
		
	
}  
}
