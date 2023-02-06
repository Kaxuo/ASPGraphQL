using API.Context;
using API.Interfaces;
using API.Models;

namespace API.Repository
{
    public class MailsRepository : IMailsRepository
    {
        private readonly ApplicationDBContext _appDbContext;
        public MailsRepository(ApplicationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Mails> GetAllMails()
        {
            return _appDbContext.Mails;
        }

        public Mails GetOneMail(int id)
        {
            return _appDbContext.Mails.Where(x => x.Id == id).First();
        }
    }
}