using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace project_st.Models
{
    public class Course
    {
        public string cName { get; set; }
        public int id { get; set; }
    }

    public class project_stDB_crs : DbContext
    {
        public DbSet<Course> courses { get; set; }
      }

}