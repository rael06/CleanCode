using System;

namespace Decorator
{
    public abstract class AbstractMailSenderDecorator : IMailSender
    {
        protected IMailSender MailSender { get; set; }

        protected AbstractMailSenderDecorator(IMailSender mailSender)
        {
            MailSender = mailSender;
        }

        public void Send(Mail mail)
        {
            MailSender.Send(mail);
        }

        public abstract void SendFast(Mail mail);
    }
}
