using System.Threading.Tasks;

namespace BlazorEmailSender.Data
{
    public interface IMailService
    {
        Task SendEmailAsync(string ToEmail, string Subject, string HTMLBody);
    }
}