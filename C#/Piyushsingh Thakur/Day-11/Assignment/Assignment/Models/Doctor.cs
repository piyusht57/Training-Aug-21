using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Assistant = new HashSet<Assistant>();
            Patient = new HashSet<Patient>();
            Prescription = new HashSet<Prescription>();
        }

        public int DocId { get; set; }
        public string DocFname { get; set; }
        public string DocLname { get; set; }
        public int? DocPhoneNumber { get; set; }
        public string DocQualification { get; set; }
        public string DocAddress { get; set; }
        public string DocSpecialist { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<Assistant> Assistant { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
