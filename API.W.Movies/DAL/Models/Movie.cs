using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Movie: AudiBaseMovies
    {
        [Required] //Este data annotation indica que el campo es obligatorio
        [Display(Name = "Nombre de la Pelicula")] //Me sirve para personalizar el nombre que se muestra en las vistas o mensajes de error
        public string Name { get; set; }
        public virtual int Duration { get; set; }
        public virtual string? Description { get; set; }
        public virtual string Clasificaion { get; set; }
    }
}
