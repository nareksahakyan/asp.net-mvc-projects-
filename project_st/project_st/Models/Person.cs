using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace project_st.Models
{
    public class Person
    {
        [DisplayName("Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }

        [DisplayName("Second Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string lName { get; set; }    
   
        [DisplayName("ID")]
        [Required]
        [RegularExpression(@"^\d{5}")]
        public int IDnumber { get; set; }

    }


    public class project_stDB_person : DbContext
    {
        public DbSet<Person> person { get; set; }
     }

}