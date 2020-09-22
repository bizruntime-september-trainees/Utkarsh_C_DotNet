using System;
using System.Collections.Generic;

namespace EntityDBFirst.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public string Email { get; set; }
        public int? Mobile { get; set; }
        public string Description { get; set; }
    }
}
