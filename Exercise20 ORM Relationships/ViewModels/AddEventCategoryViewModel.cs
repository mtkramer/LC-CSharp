﻿using System.ComponentModel.DataAnnotations;

namespace Exercise20_ORM_Relationships.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Name { get; set; }
    }
}
