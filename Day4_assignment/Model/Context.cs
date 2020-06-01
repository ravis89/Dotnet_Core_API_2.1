using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day4_assignment.Model
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
                       
        }
        public DbSet<Product> Products { get; set; }
    }
}
