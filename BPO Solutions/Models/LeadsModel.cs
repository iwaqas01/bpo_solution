using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class LeadsModel
    {
        public int ID { get; set; }
        [Display(Name = "Employee ID")]
        [Required]

        public Nullable<int> Emp_ID { get; set; }
        [Display(Name = "Number of Leads")]
        [Required]

        public Nullable<int> No_Of_Leads { get; set; }

    }
}