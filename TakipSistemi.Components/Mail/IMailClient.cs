using System;
using System.Threading.Tasks;

namespace TakipSistemi.Components.Mail
{
    public interface IMailClient
    {
        Task SendAsync(String email, String subject, String body);
    }
}
