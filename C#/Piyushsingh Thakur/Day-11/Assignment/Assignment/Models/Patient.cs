using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        public int PatId { get; set; }
        public string PatFname { get; set; }
        public string PatLname { get; set; }
        public int? PatPhoneNumber { get; set; }
        public DateTime? PatDob { get; set; }
        public string PatAddress { get; set; }
        public int? DocId { get; set; }
        public int? AssisId { get; set; }
        public string Gender { get; set; }

        public virtual Assistant Assis { get; set; }
        public virtual Doctor Doc { get; set; }
        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
