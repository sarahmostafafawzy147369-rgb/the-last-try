﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyProject.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
        public string? Employee_Name { get; set; }
        public int Employee_Salary {  get; set; } 
    }
}
