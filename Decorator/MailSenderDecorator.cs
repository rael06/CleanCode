using System;

namespace Decorator
{
    public class MailSenderDecorator : AbstractMailSenderDecorator
    {
        public MailSenderDecorator(IMailSender mailSender) : base(mailSender)
        {
        }

        public override void SendFast(Mail mail)
        {
            Console.Write("Fast ");
            MailSender.Send(mail);
        }
    }
}
