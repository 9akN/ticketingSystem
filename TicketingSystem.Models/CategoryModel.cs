﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
