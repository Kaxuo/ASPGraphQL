using API.ConsumerModels;
using API.Interfaces;
using API.Models;
using API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class MailsController : Controller
    {
        private readonly IMapper _mapper;
        IMailsRepository _mailsRepository = null!;
        IUsersRepository _usersRepository = null!;
        public MailsController(IMailsRepository mailsRepository, IMapper mapper, IUsersRepository usersRepository)
        {
            _mapper = mapper;
            _mailsRepository = mailsRepository;
            _usersRepository = usersRepository;
        }
        [HttpGet("all")]
        public IEnumerable<ConsumerMail> GetAllMails()
        {
            var mails = _mailsRepository.GetAllMails();
            return _mapper.Map<IEnumerable<ConsumerMail>>(mails);
        }

        [HttpGet("users")]
        public IEnumerable<ConsumerUser> GetAllUsers()
        {
            var users = _usersRepository.GetAllUsers();
            return _mapper.Map<IEnumerable<ConsumerUser>>(users);
        }
    }
}