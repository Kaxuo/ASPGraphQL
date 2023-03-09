using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Sender is required")]
        public string Name { get; set; } = null!;
        public ICollection<Mail> Mails { get; set; } = new Collection<Mail>();
    }
}