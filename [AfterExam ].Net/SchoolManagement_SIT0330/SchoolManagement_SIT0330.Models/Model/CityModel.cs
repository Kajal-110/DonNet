using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Models.Model
{
    public class CityModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }

        public string CountryName { get; set; }

        public string StateName { get; set; }
    }
}
