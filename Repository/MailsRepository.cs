using API.Context;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class MailsRepository : IMailsRepository
    {
        private readonly ApplicationDBContext _appDbContext;
        public MailsRepository(ApplicationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public IEnumerable<Mail> GetAllMails()
        {
            return _appDbContext.Mails.Include(x => x.User);
        }

        public Mail GetOneMail(int id)
        {
            return _appDbContext.Mails.Where(x => x.Id == id).Include(x => x.User).First();
        }
    }
}