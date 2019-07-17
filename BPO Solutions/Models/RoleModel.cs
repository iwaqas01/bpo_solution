using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class RoleModel
    {
        public int ID { get; set; }
        [Display(Name = "User ID")]
        [Required]

        public Nullable<int> User_ID { get; set; }
        [Display(Name = "Role")]
        [Required]

        public string Role1 { get; set; }


    }
}