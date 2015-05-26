using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace project_st.Models
{
    public class Student:Person
    {
        public int id { get; set; }   
        public List<Course> Courses { get; set; }

    }

    
    public class project_stDB_stud: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<project_st.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<project_st.Models.Course> Courses { get; set; }
      }

}