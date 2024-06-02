using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

namespace PersonalBlogApp.Views.Contact
{
    public class IndexModel : PageModel
    {
        public void OnGet() { }
        public void OnPost() {
            var name = Request.Form["name"];
            var email = Request.Form["emailaddress"];
            var message = Request.Form["message"];

            SendMail(name, email, message);
        }

        public bool SendMail(string name,string email,string message1)
        {
            
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            message.From = new MailAddress("kaaneris7@gmail.com");
            message.To.Add("kaaneris7@gmail.com");
            message.Subject = "Test Email";
            message.IsBodyHtml = true;
            message.Body = "<p>İsim:" + name + "</p>" + "<p>Email:" + email + "</p>" + "<p>Mesaj:" + message1 + "</p>";
            smtpClient.Port = 5255;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("denemesender01@gmail.com", "Sender13252513");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
            return true;

        }
    }
}
