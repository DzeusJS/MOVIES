﻿using System.ComponentModel.DataAnnotations;

namespace MOVIES.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

		[Display(Name = "Profile picture")]
		public string ProfilePictureURL { get; set; }

		[Display(Name = "Full Name")]
		public string FullName { get; set; }

		[Display(Name = "Biography")]
		public string Bio { get; set; }

		//Relationships
		public List<Movie> Movies { get; set; }
    }
}
