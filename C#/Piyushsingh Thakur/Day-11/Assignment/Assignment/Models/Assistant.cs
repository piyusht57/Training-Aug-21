using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Assistant
    {
        public Assistant()
        {
            Patient = new HashSet<Patient>();
        }

        public int AssisId { get; set; }
        public string AssisFname { get; set; }
        public string AssisLname { get; set; }
        public int? AssisPhoneNumber { get; set; }
        public string AssisQualification { get; set; }
        public string AssisAddress { get; set; }
        public int? DocId { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
