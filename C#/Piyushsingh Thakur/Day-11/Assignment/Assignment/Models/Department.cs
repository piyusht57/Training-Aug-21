using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctor = new HashSet<Doctor>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
    }
}
