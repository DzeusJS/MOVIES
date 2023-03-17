using MOVIES.DATA.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOVIES.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
		[Display(Name = "Name")]
		public string? Name { get; set; }
		[Display(Name = "Description")]
		public string? Description { get; set; }
		[Display(Name = "Start date")]
		public DateTime StartDate { get; set; }
		[Display(Name = "End date")]
		public DateTime EndDate { get; set; }
		[Display(Name = "Price")]
		public double Price { get; set; }
		[Display(Name = "Image")]
		public string? ImageURL { get; set; }
		[Display(Name = "Category")]
		public MovieCategory MovieCategory { get; set; }


        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey(" ProducerId ")]
        public Producer? Producer { get; set; }
    }
}
