using API.Context;
using API.Interfaces;
using API.Models;
using API.Repository;

namespace API.Queries
{
    public class QueryMails
    {
        IMailsRepository _mailsRepository = null!;
        public QueryMails(IMailsRepository mailsRepository)
        {
            _mailsRepository = mailsRepository;
        }
        public IQueryable<Mails> GetMails([Service] ApplicationDBContext context) => _mailsRepository.GetAllMails();
        public Mails? GetMailId([Service] ApplicationDBContext context, int id) => _mailsRepository.GetOneMail(id);
    }
}