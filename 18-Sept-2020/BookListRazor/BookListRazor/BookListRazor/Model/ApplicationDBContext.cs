using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDBContext: DbContext
    {
        //.....parameter for Constructor is needed for Dependency Injection
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        //.....To add any model to database inside DbContext  , we need an Entry
        public DbSet<Book> Book { get; set; }  //.......Entry.........

        //.......Now add DbContext inside startup.cs
    }
}