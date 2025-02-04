﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string? Username { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string? SshKey { get; set; }
    }
}
