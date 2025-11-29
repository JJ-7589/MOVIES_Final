using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Movie: AudiBaseMovies
    {
        [Required]
        [Display(Name = "Nombre de la Pelicula")] 
        public string Name { get; set; }
        public virtual int Duration { get; set; }
        public virtual string? Description { get; set; }
        public virtual string Clasificaion { get; set; }
    }
}
