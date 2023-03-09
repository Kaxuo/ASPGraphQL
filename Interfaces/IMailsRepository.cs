using API.Models;

namespace API.Interfaces
{
    public interface IMailsRepository
    {
        public IEnumerable<Mail> GetAllMails();
        public Mail GetOneMail(int id);
    }
}