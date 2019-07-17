using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class ExpensesModel
    {
        public int ID { get; set; }
        [Display(Name = "Expense Name")]
        [Required]

        public string Expense_Name { get; set; }
        [Display(Name = "Amount")]
        [Required]

        public Nullable<int> Amount { get; set; }
        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Date { get; set; }


    }
}