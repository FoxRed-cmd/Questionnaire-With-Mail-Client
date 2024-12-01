using MimeKit;
using Questionnaire.Services;

namespace Questionnaire
{
    public partial class InboxEmailForm : Form
    {
        private List<MimeEntity> files = [];
        public InboxEmailForm()
        {
            InitializeComponent();
            inboxList.MultiSelect = false;
            inboxList.FullRowSelect = true;

        }

        private async Task CheckInbox()
        {
            //Пиши свою почту и пароль
            EmailService emailService = new("mail@yandex.ru", "YOUR_SUPER_SECRET_PASSWORD",
               "smtp.yandex.ru", 465, "imap.yandex.ru", 993, true);

            var messages = await emailService.GetIncomingEmailsWithDataAttachmentsAsync();

            if (messages != null && messages.Any())
            {
                foreach (var message in messages)
                {
                    foreach (var file in message.Attachments)
                    {
                        var fileName = file.ContentDisposition?.FileName ?? file.ContentType.Name;
                        inboxList.Items.Add(new ListViewItem([message.From.ToString(), message.Date.ToString(), fileName]));
                        files.Add(file);
                    }
                }

                inboxList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                MessageBox.Show("Сообщений с данными не найдено...", "Входящие сообщения",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void InboxEmailFormLoad(object sender, EventArgs e)
        {
            Task task = CheckInbox();
            InboxTitle.Text = "Загрузка";

            for (int i = 0; i < 3; i++)
            {
                InboxTitle.Text += '.';
                await Task.Delay(300);

                if (i == 2)
                {
                    i = -1;
                    InboxTitle.Text = "Загрузка";
                }

                if (task.IsCompleted)
                    break;
            }

            InboxTitle.Text = "Входящие сообщения с данными";
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (inboxList.SelectedIndices.Count == 0)
                return;

            MimeEntity file = files[inboxList.SelectedIndices[0]];
            var fileName = file.ContentDisposition?.FileName ?? file.ContentType.Name;

            using SaveFileDialog saveFileDialog = new()
            {
                Filter = fileName.EndsWith(".json") ? "json files (*.json)|*.json" : "xml files (*.xml)|*.xml",
                FilterIndex = 0,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Сохранить",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using var stream = File.Create(saveFileDialog.FileName);
                if (file is MessagePart)
                {
                    var rfc822 = (MessagePart)file;
                    rfc822.Message.WriteTo(stream);
                }
                else
                {
                    var part = (MimePart)file;
                    part.Content.DecodeTo(stream);
                }
            }
        }
    }
}
