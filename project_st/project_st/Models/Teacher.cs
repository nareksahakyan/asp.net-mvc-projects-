using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace project_st.Models
{
    public class Teacher:Person
    {
        public int id { get; set; }

        public List<Course> Courses { get; set; }
    }

    public class project_stDB_teach : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
     }

}