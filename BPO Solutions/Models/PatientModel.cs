using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class PatientModel
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required]

        public string First_Name { get; set; }
        [Display(Name = "Last Name")]
        [Required]

        public string Last_Name { get; set; }
        [Display(Name = "Phone Number")]
        [Required]

        public string Phone_no { get; set; }
        [Display(Name = "Street Address")]
        [Required]

        public string Address { get; set; }
        [Display(Name = "City and State")]
        [Required]

        public string City_State { get; set; }
        [Display(Name = "Zipcode")]
        [Required]

        public Nullable<int> Zipcode { get; set; }
        [Display(Name = "Area Of Pain")]
        [Required]

        public string Area_Of_Pain { get; set; }
        [Display(Name = "Health Insurance ID Number")]
        [Required]

        public string Health_Insurance_Id { get; set; }
        [Display(Name = "Date Of Birth")]
        [Required]
        [DataType(DataType.Date)]

        public string DOB { get; set; }
        [Display(Name = "Status")]
        [Required]

        public string Status { get; set; }

    }
}