﻿using System.ComponentModel.DataAnnotations;

namespace Reading21_Authentication.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        public Tag() {  }
        public Tag(string name) { Name = name; }
    }

}
