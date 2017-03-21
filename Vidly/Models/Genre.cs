﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre  
    {
        [Required]
        [Display(Name = "Genre")]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Genre")]
        public string Name { get; set; }
    }
}