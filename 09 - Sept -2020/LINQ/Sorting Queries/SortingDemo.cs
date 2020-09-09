
using System;
using System.Collections.Generic;

using System.Linq;

class Student  
    {  
        public string Name { get; set; }  
        public string Gender { get; set; }  
        public List<string> Subjects { get; set; }  
    }  
	
	
   public  class Program
    {  
      public static void Main(string[] args) 
        {  
            List<Student> Objstudent = new List<Student>(){  
        new Student() { Name = "Utkarsh Pant", Gender = "Male", Subjects = new List<string> { "Network theory", "Control System" } },  
        new Student() { Name = "Rohini ", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },  
        new Student() { Name = "Praveen", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },  
        new Student() { Name = "Sateesh ", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },  
        new Student() { Name = "Madhav", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }  
        };  
            var studentname = Objstudent.OrderBy(x => x.Name);  
            foreach (var student in studentname)  
            {  
                Console.Write(student.Name+" , ");  
            }  
			
			studentname = Objstudent.OrderBy(x => x.Subjects);
			
			foreach (var student in studentname)  
            {  
                Console.Write(student.Name+" , ");  
            } 
			Console.WriteLine();
			
		
			//..........Sorting according to Descending order..........
		
			studentname = Objstudent.OrderByDescending(x => x.Name);
			
			foreach(var student in studentname){
				
				Console.Write(student.Name +" ");
			}
			
			Console.WriteLine();
               
    }  
}  
    
