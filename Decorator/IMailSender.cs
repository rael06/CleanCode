using System.Net.Mail;

namespace Decorator
{
    public interface IMailSender
    {
        void Send(Mail mail);
    }
}
