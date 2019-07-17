using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class Diabetic_PatientsModel
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

        public string Phone_No { get; set; }
        [Display(Name = "Address")]
        [Required]

        public string Address { get; set; }
        [Display(Name = "City and State")]
        [Required]

        public string City_State { get; set; }
        [Display(Name = "Zipcode")]
        [Required]

        public string Zipcode { get; set; }
        [Display(Name = "Date of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
        [Display(Name = "Health Insurance ID Number")]
        [Required]

        public string Health_Insurance_ID { get; set; }
        [Display(Name = "Diabetes Type")]
        [Required]

        public string Diabetes_Type { get; set; }
        [Display(Name = "Insurance Status")]
        [Required]

        public string Status { get; set; }


        public enum DBType
        {
            Type1,
            Type2
        }

    }
}