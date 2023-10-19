﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

    }
}
