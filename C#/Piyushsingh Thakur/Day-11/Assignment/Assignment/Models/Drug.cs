using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.Models
{
    public partial class Drug
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public int? MorningDose { get; set; }
        public int? AfternoonDose { get; set; }
        public int? NightDose { get; set; }
        public int? PreId { get; set; }

        public virtual Prescription Pre { get; set; }
    }
}
