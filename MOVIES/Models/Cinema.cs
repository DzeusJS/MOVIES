﻿using System.ComponentModel.DataAnnotations;

namespace MOVIES.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
		[Display(Name = "Cinema logo")]
		public  string? Logo { get; set; }

		[Display(Name = "Name")]
		public string? Name { get; set; }
		[Display(Name = "Description")]
		public string? Description { get; set; }

        public List<Movie>? Movies { get; set; }
    }
}
