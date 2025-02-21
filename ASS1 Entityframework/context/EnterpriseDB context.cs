using ASS1_Entityframework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_Entityframework.context
{
    internal class EnterpriseDB_context:DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
                       
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EMAN_RADY\\MSSQLSERVER01;Database = Iti;Trusted_connection=true;Trustservercertificate=true");
        }

        public DbSet <Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Topic> Topic { get; set; }

        public DbSet<Course_Inst> Course_Insts { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set;}

       public DbSet<Ddepartment> Ddepartments { get; set; } 

        public DbSet<Instructor> Instructors { get; set; }
        


    }
}
