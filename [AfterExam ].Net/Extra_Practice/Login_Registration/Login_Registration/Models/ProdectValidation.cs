using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login_Registration.Models
{
    public class ProdectValidation
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public Nullable<decimal> Price { get; set; }
    }
    [MetadataType(typeof(ProdectValidation))]
    public partial class Product
    {

    }
}