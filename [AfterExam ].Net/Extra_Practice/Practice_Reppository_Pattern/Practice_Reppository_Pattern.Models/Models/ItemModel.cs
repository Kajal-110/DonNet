using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Reppository_Pattern.Models.Models
{
    public class ItemModel
    {

        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
    }
}
