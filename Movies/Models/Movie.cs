using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int id { get; set; }
        [Display(Name = "Título")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de liberación")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Género")]
        public string? Genre { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }
}
