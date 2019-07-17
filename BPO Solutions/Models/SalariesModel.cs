using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class SalariesModel
    {
        public int ID { get; set; }
        [Display(Name = "Employee ID")]
        [Required]

        public Nullable<int> Emp_ID { get; set; }
        [Display(Name = "Salary")]
        [Required]

        public Nullable<int> Salary { get; set; }
        [Display(Name = "Date")]
        [Required]

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Date { get; set; }

    }
}