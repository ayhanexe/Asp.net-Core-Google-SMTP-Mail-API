using Asp.net_core_email_service.Models;
using System.Threading.Tasks;

namespace Asp.net_core_email_service.Services
{
    public interface IMailService
    {
        public Task SendMailAsync(MailRequest mailRequest);
    }
}
