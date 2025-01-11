﻿using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}