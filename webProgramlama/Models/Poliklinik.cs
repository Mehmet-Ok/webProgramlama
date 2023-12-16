﻿using System.ComponentModel.DataAnnotations;

namespace webProgramlama.Models
{
    public class Poliklinik
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int anaBilimDaliID { get; set; }

        [Required]
        public string ad { get; set; }

    }
}
