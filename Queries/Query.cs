using API.Interfaces;
using API.Models;

namespace API.Queries
{
    public class Query
    {
        //Users//
        public IEnumerable<User> GetUsers([Service] IUsersRepository usersRepository) => usersRepository.GetAllUsers();
        public User? GetUserId([Service] IUsersRepository usersRepository, int id) => usersRepository.GetOneUser(id);
        //Mails//
        public IEnumerable<Mail> GetMails([Service] IMailsRepository mailsRepository) => mailsRepository.GetAllMails();
        public Mail? GetMailId([Service] IMailsRepository mailsRepository, int id) => mailsRepository.GetOneMail(id);

    }
}