//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Order.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int TeaacherId { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> Gender { get; set; }
        public string City { get; set; }
    }
}