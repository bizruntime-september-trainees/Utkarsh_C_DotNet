using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreWebApiDemo.Models
{
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public int? Phone { get; set; }
    }
}
