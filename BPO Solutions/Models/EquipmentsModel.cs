using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class EquipmentsModel
    {
        public int ID { get; set; }
        [Display(Name = "Equipment Name")]
        [Required]

        public string Equipment_Name { get; set; }
        [Display(Name = "Quantity")]
        [Required]

        public Nullable<int> Quantity { get; set; }

    }
}