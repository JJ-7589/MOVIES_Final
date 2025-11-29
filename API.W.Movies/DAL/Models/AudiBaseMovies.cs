using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AudiBaseMovies
    {
        [Key]
        public virtual int IdM { get; set; }
        public virtual  DateTime CreatedDate { get; set; }

        public virtual DateTime? UpdatedDate { get; set; }
        
    }
}
