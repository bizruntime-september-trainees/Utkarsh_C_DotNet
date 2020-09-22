using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreWebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var context = new StudentContext()) {

                //1.  .......To get list of all students

                return context.Student.ToList();

                //2.    Get student by id

            //    return context.Student.Where(student => student.Id == 1);

                //3     Adding a student into database..........

                //Student student = new Student();
                //student.Phone = 943050;

                //context.Student.Add(student);
                //context.SaveChanges();

               // return context.Student.Where(student => student.Id == 1).ToList();

            }
        }
    }
}
