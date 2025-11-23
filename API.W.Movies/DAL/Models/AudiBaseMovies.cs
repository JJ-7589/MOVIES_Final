using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AudiBaseMovies
    {
        [Key] //Este data annotation indica que el campo es la clave primaria
        public virtual int IdM { get; set; }
        public virtual  DateTime CreatedDate { get; set; }

        public virtual DateTime? UpdatedDate { get; set; }
        
    }
}
