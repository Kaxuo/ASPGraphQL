using API.Models;

namespace API.Interfaces
{
    public interface IUsersRepository
    {
        public IEnumerable<User> GetAllUsers();
        public User GetOneUser(int id);
    }
}