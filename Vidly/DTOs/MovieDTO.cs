﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        //[StockLimits]
        public byte NumberInStock { get; set; }
    }
}