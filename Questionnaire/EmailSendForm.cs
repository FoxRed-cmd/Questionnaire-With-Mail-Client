using Questionnaire.Services;

namespace Questionnaire
{
    public partial class EmailSendForm : Form
    {
        private string filter = "object files (*.json;*.xml)|*.json;*.xml";
        private string path;
        public EmailSendForm()
        {
            InitializeComponent();
            path = string.Empty;
            addFileName.Text = string.Empty;
        }

        private async void BtnSendClick(object sender, EventArgs e)
        {
            btnSend.Enabled = false;

            //Ставь свою почту и пароль
            EmailService emailService = new("mail@yandex.ru", "YOUR_SUPER_SECRET_PASSWORD", 
                "smtp.yandex.ru", 465, "imap.yandex.ru", 993, true);

            try
            {
                await emailService.SendEmailAsync("Приложение Questionnarie",
                    txtEmail.Text, txtSubject.Text, txtMessage.Text, path);
                btnSend.Enabled = true;
                btnSend.Text = "Отправлено!";
                await Task.Delay(1000);
                btnSend.Text = "Отправить";
            }
            catch (Exception ex)
            {
                MessageBox.Show("При отправке сообщения произошла ошибка:" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
            }
            
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Filter = filter,
                FilterIndex = 0,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = false,
                Title = "Открыть",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                addFileName.Text = Path.GetFileName(openFileDialog.FileName);
                path = openFileDialog.FileName;
            }
        }
    }
}
