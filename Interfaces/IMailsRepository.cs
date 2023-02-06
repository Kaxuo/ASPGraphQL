using API.Models;

namespace API.Interfaces
{
    public interface IMailsRepository
    {
        public IQueryable<Mails> GetAllMails();
        public Mails GetOneMail(int id);
    }
}