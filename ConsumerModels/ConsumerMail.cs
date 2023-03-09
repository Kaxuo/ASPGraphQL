
using System.Text.Json.Serialization;

namespace API.ConsumerModels
{
    public class ConsumerMail
    {
        public int Id { get; set; }
        public string Subject { get; set; } = null!;
        public string Content { get; set; } = null!;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ConsumerUser User { get; set; } = null!;
    }
}