using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Mails
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Sender is required")]
        public string Sender { get; set; } = null!;
        [Required(ErrorMessage = "Receiver is required")]
        public string Receiver { get; set; } = null!;
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; } = null!;
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; } = null!;
        [Required(ErrorMessage = "Value is required")]
        public bool Fake { get; set; }
    }
}