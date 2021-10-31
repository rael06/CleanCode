namespace Decorator
{
    public class Mail
    {
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return $"From: {MailFrom}, To: {MailTo}, Subject: {Subject}, Content: {Content}";
        }
    }
}
