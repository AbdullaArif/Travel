using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

using Travel.Models;

namespace Travel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "mail adress");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Subject = mailRequest.Subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body= bodyBuilder.ToMessageBody();
            //mimeMessage.Body = mailRequest.Body;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("mail address", "12345");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
