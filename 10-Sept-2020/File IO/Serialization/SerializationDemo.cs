using System;  
using System.IO;  
using System.Runtime.Serialization.Formatters.Binary;  
[Serializable]  
class Student  
{  
     int rollno;  
     string name;  
    Student(int rollno, string name)  
    {  
        this.rollno = rollno;  
        this.name = name;  
    }  
}  
public class SerializeExample  
{  
    public static void Main(string[] args)  
    {  
        FileStream stream = new FileStream("e:\\abc.txt", FileMode.OpenOrCreate);  
        BinaryFormatter formatter=new BinaryFormatter();  
          
        Student s = new Student(101, "Utkarsh Pant");  
		
        formatter.Serialize(stream, s);
        stream.Close();  
		Console.ReadKey();
    }  
}  