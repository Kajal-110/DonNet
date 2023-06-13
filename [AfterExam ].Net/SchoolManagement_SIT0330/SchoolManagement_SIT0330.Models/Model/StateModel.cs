using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Models.Model
{
    public class StateModel
    {
        [Required]
        public int StateId { get; set; }
        [Required]
        public string StateName { get; set; }
        [Required]
        public Nullable<int> CountryId { get; set; }

        public string CountryName { get; set; }
    }
}
