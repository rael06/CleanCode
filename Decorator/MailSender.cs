using System;

namespace Decorator
{
    public class MailSender : IMailSender
    {
        public void Send(Mail mail)
        {
            Console.WriteLine($"Sending mail: {mail}");
        }
    }
}
