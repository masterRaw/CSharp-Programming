using Microsoft.EntityFrameworkCore;
using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options) 
        { 

        }

        public DbSet<Category> Category { get; set; }

    }
}
