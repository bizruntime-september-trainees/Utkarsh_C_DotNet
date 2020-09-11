using System;  
using System.IO;  
using System.Runtime.Serialization.Formatters.Binary;  
[Serializable]  

//........We are deserializing Student class object.........

	class Student  {  
	
    public int rollno;  
    public string name;  
	
    public Student(int rollno, string name)  
    {  
        this.rollno = rollno;  
        this.name = name;  
    }  
}  
	public class DeserializationDemo 
{  
    public static void Main(string[] args)  
    {

try{		
        FileStream stream = new FileStream("e:\\abc.txt", FileMode.OpenOrCreate);  
        BinaryFormatter f = new BinaryFormatter();  
  
        Student s=(Student)f.Deserialize(stream);  
        Console.WriteLine("Rollno: " + s.rollno);  
        Console.WriteLine("Name: " + s.name);  
  
    
    stream.Close();  
}

catch (Exception e){
	
	Console.WriteLine(e);
}
		Console.ReadKey();
    }  
}  
