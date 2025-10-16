using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyProject.Models
{
    public class Car
    {
        [Key]
        public int Car_ID { get; set; }
        public string? Car_Name {  get; set; }   
    }
}
