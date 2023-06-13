using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Models.Model
{
    class StandradModel
    {
        [Required]
        public int StandardId { get; set; }
        [Required]
        public string StandardName { get; set; }
    }
}
