using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Models
{
    public class Mail
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Sender is required")]
        public string Subject { get; set; } = null!;
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; } = null!;
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
    }
}