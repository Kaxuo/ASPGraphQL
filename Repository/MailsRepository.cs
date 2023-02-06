using API.Context;
using API.Interfaces;

namespace API.Repository
{
    public class MailsRepository : IMailsRepository
    {
        private readonly ApplicationDBContext? _appDbContext;
        public MailsRepository(ApplicationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}