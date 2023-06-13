using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Models.Model
{
    public class TeacherModel
    {
        public int TeacherId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public Nullable<int> CityId { get; set; }
        [Required]
        public Nullable<int> StateId { get; set; }
        [Required]
        public Nullable<int> CountryId { get; set; }
        [Required]
        public Nullable<int> StandardId { get; set; }
        [Required]
        public Nullable<int> SubjectId { get; set; }
        
        public string CountryName { get; set; }
        
        public string StateName { get; set; }
        
        public string CityName { get; set; }

    }
}
