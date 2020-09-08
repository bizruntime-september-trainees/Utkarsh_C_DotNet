using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void main(string[] args)
    {
        List<Employee> l = new List<Employee>();

    }

}
    
    class Employee
    {

        public int ID { get; set; }
        public String Name { get; set; }

        public String Salary { get; set; }

        public String Experience { get; set; }

        public static void PromoteEmployees(List<Employee> empList) {

            foreach (Employee emp in empList) { 
            
                if(emp.Experience >= 2)
                {
                    Console.WriteLine(emp.Name +" is Promoted");
                }
            }
        }
    }

