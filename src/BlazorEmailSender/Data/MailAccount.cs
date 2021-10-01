namespace BlazorEmailSender.Data
{
    public class MailAccount
    {
        /// <summary>
        /// Credentials.Account
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Credentials.Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// SMTP Port (25 or 465 or 587)
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Mail Sender Address
        /// </summary>
        public string SenderMail { get; set; }
        /// <summary>
        /// Mail Server
        /// </summary>
        public string Host { get; set; }
    }
}