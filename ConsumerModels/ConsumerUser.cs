using System.Collections.ObjectModel;
using API.Models;

namespace API.ConsumerModels
{
    public class ConsumerUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ConsumerMail> Mails { get; set; } = new Collection<ConsumerMail>();
    }
}