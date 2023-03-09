using API.Context;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDBContext _appDbContext;
        public UsersRepository(ApplicationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _appDbContext.Users.Include(x => x.Mails);
        }

        public User GetOneUser(int id)
        {
            return _appDbContext.Users.Where(x => x.Id == id).Include(x => x.Mails).First();
        }
    }
}