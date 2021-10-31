using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new Mail
            {
                MailFrom = "Toto",
                MailTo = "Tata",
                Subject = "Email from component",
                Content = "Hello Tata, Your friend Super Toto"
            };

            var mailSender = new MailSender();
            var fastMailSender = new MailSenderDecorator(mailSender);
            mailSender.Send(mail);
            fastMailSender.Send(mail);
            fastMailSender.SendFast(mail);
        }
    }
}
