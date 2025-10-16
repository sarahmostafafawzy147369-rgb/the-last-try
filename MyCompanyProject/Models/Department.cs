using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyProject.Models
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }
         public string? Department_Name {  get; set; }
         public int Employee_Id{  get; set; }
          [ForeignKey ("Employee_Id")]
         public Employee ?Employee { get; set; }  
         public int Car_Id { get; set; }
         [ForeignKey("Car_Id")]
         public Car ?Car { get; set; }

    }
}
