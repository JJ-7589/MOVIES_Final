using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int IdM { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdateDate { get; set; }
        [Required(ErrorMessage = "La duracion de la pelicula es obligatoria.")]
        public int Duration { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "la calsificacion de la pelicula es obligatorio.")]
        [MaxLength(10, ErrorMessage = "El número máximo de caracteres es de 10.")]
        public string Clasificaion { get; set; }
    }
}
