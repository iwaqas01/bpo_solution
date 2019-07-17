using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string Emp_Name { get; set; }
        [Display(Name = "Father Name")]
        [Required]
        public string FatherName { get; set; }
        [Display(Name = "Phone Number")]
        [Required]
        public string CellNo { get; set; }
        [Display(Name = "Shift")]
        [Required]
        public string Shift { get; set; }
    }
}