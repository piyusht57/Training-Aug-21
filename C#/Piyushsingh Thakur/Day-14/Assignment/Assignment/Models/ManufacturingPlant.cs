﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class ManufacturingPlant
    {
        [Key]
        public int PlantId { get; set; }
        public string PlantName { get; set; }

        public ICollection<Toys> Toys { get; set; }   //Toys table linked with manufacturing plant
    }
}
