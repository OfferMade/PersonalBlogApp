using Entities.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Org.BouncyCastle.Crypto.Macs;
using Services.Contracts;


namespace PersonalBlogApp.Controllers
{
    public class ContactController : Controller
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
            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "denemesender01@gmail.com");
            mimeMessage.From.Add(mailboxAddress);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            mimeMessage.Subject = mailRequest.Subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);

            client.Authenticate("denemesender01@gmail.com", "uebg maji ypyx ozrt\r\n");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }

    }
}
