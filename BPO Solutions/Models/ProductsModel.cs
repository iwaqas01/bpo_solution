using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class ProductsModel
    {
        public int ID { get; set; }
        [Display(Name = "Product Name")]
        [Required]

        public string Product_Name { get; set; }
        [Display(Name = "Product Description")]
        [Required]

        public string Product_Description { get; set; }

    }
}