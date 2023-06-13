using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Models.Model
{
    public class CountryModel
    {
        [Required]
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
