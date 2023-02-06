using API.Interfaces;
using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class MailsController : Controller
    {
        IMailsRepository _mailsRepository = null!;
        public MailsController(IMailsRepository mailsRepository)
        {
            _mailsRepository = mailsRepository;
        }
        [HttpGet("all")]
        public IQueryable<Mails> GetAbsorbedPortfoliosAsync()
        {
            return _mailsRepository.GetAllMails();
        }
    }
}