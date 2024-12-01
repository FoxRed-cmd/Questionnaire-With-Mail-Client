using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace Questionnaire.Services
{
    internal class EmailService
    {
        public string EmailLogin { get; private set; }
        public string Password { get; private set; }
        public string Smtp { get; private set; }
        public string Imap { get; private set; }
        public int SmtpPort { get; private set; }
        public int ImapPort { get; private set; }
        public bool UseSsl { get; private set; }
        public EmailService(string emailLogin, string password, string smtp, int smtpPort, string imap, int imapPort, bool useSsl)
        {
            EmailLogin = emailLogin;
            Password = password;
            Smtp = smtp;
            SmtpPort = smtpPort;
            Imap = imap;
            ImapPort = imapPort;
            UseSsl = useSsl;
        }

        public async Task SendEmailAsync(string nameFrom, string emailTo,
            string subject, string message, string attachmentPath = "")
        {
            using MimeMessage mimeMessage = new();

            mimeMessage.From.Add(new MailboxAddress(nameFrom, EmailLogin));
            mimeMessage.To.Add(new MailboxAddress(string.Empty, emailTo));
            mimeMessage.Subject = subject;

            var body = new BodyBuilder();
            body.TextBody = message;

            if (attachmentPath != string.Empty)
            {
                body.Attachments.Add(attachmentPath);
            }

            mimeMessage.Body = body.ToMessageBody();

            using var client = new MailKit.Net.Smtp.SmtpClient();
            await client.ConnectAsync(Smtp, SmtpPort, UseSsl);

            await client.AuthenticateAsync(EmailLogin, Password);
            await client.SendAsync(mimeMessage);

            await client.DisconnectAsync(true);
        }

        public async Task<IEnumerable<MimeMessage>> GetIncomingEmailsWithDataAttachmentsAsync()
        {
            List<MimeMessage> messages = new();

            using var client = new ImapClient();
            await client.ConnectAsync(Imap, ImapPort, UseSsl);

            await client.AuthenticateAsync(EmailLogin, Password);

            var folder = client.Inbox;
            await folder.OpenAsync(FolderAccess.ReadOnly);

            await Task.Run(() =>
            {
                foreach (var message in folder)
                {
                    if (message.Attachments.Any())
                    {
                        foreach (var file in message.Attachments)
                        {
                            var fileName = file.ContentDisposition?.FileName ?? file.ContentType.Name;
                            if (fileName.EndsWith(".json") || fileName.EndsWith(".xml"))
                            {
                                messages.Add(message);
                                break;
                            }
                        }
                    }
                }
            });

            return messages;
        }
    }
}
