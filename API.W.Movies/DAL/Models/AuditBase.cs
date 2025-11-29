using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AuditBase
    {
        [Key] 
        public virtual int Id { get; set; }

        public virtual DateTime CreationsDate { get; set; }

        public virtual DateTime? ModidyedDate { get; set; }
    }
}
