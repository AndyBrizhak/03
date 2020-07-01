namespace MailSender
{
    class EMailInfo
    {
        public string SMTPClient { get; set; }
        public int  Port { get; set; }
        public  string  Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Password { get;   set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}
