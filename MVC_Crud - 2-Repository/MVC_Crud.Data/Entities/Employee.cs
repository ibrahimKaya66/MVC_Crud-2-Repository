using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Crud.Models
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Wage { get; set; }//Maaş
        public int Department_Id { get; set; }
        public Department Department { get; set; }
    }
}