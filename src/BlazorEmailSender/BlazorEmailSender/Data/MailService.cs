using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorEmailSender.Data
{
    public class MailService:IMailService
    {
        private readonly MailAccount _mailAccount;

        public MailService(MailAccount mailAccount)
        {
            _mailAccount = mailAccount;
        }
        
        public async Task SendEmailAsync(string ToEmail, string Subject, string HTMLBody)
        {
            SmtpClient smtp = new SmtpClient()
            {
                Port = _mailAccount.Port,
                Host = _mailAccount.Host,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_mailAccount.Account, _mailAccount.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            
            MailMessage message = new MailMessage()
            {
                From = new MailAddress(_mailAccount.SenderMail),
                Subject = Subject,
                IsBodyHtml = true,
                Body = HTMLBody  
            };
            
            message.To.Add(new MailAddress(ToEmail));
            await smtp.SendMailAsync(message);
        }
        
        public void SendEmail(string ToEmail, string Subject, string HTMLBody)
        {
            SmtpClient smtp = new SmtpClient()
            {
                Port = _mailAccount.Port,
                Host = _mailAccount.Host,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_mailAccount.Account, _mailAccount.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            
            MailMessage message = new MailMessage()
            {
                From = new MailAddress(_mailAccount.SenderMail),
                Subject = Subject,
                IsBodyHtml = true,
                Body = HTMLBody  
            };
            
            message.To.Add(new MailAddress(ToEmail));
            smtp.Send(message);
        }
    }
}