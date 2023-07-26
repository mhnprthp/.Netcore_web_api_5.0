using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testemp.Model
{
    public class Employee
    {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public string EmpFirstName { get; set; }

       
       
        public string EmpLastName { get; set; }

     
        public string EmpEmail { get; set; }

       
        public string EmpPhone { get; set; }

 
        public string EmpDepartment { get; set; }
    }
}