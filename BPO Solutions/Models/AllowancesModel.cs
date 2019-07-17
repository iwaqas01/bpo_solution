using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class AllowancesModel
    {
        public int ID { get; set; }
        [Display(Name = "Employee ID")]
        [Required]
        public Nullable<int> Emp_ID { get; set; }
        [Display(Name = "Allowance Name")]
        [Required]

        public string Allowance_Name { get; set; }
        [Display(Name = "Amount")]
        [Required]

        public Nullable<int> Amount { get; set; }

    }
}