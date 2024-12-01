using Questionnaire.Helpers;
using Questionnaire.Model;
using Questionnaire.Services;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class MainForm : Form
    {
        private enum FilterMode
        {
            All,
            ByYes,
            ByNo,
        }

        private List<Survey> surveys;

        private readonly Color backColor = Color.FromArgb(27, 34, 42);
        private readonly Color foreColor = Color.FromArgb(224, 232, 255);
        private readonly Color backAccentColor = Color.FromArgb(54, 64, 70);

        public MainForm()
        {
            InitializeComponent();

            BackColor = backColor;
            ForeColor = foreColor;

            listBox.ForeColor = foreColor;
            filterBox.ForeColor = foreColor;
            infoBox.ForeColor = foreColor;

            addButton.BackColor = backAccentColor;

            menuStrip1.BackColor = backAccentColor;
            menuStrip1.ForeColor = foreColor;

            firstNameTxt.BackColor = backAccentColor;
            secondNameTxt.BackColor = backAccentColor;
            lastNameTxt.BackColor = backAccentColor;
            ageList.BackColor = backAccentColor;
            educationTxt.BackColor = backAccentColor;
            questionTxt.BackColor = backAccentColor;

            firstNameTxt.ForeColor = foreColor;
            secondNameTxt.ForeColor = foreColor;
            lastNameTxt.ForeColor = foreColor;
            ageList.ForeColor = foreColor;
            educationTxt.ForeColor = foreColor;
            questionTxt.ForeColor = foreColor;

            dataList.BackgroundColor = backAccentColor;
            dataList.ForeColor = backAccentColor;

            surveys = [];

            firstNameTxt.TextChanged += TextChangedEvent;
            secondNameTxt.TextChanged += TextChangedEvent;
            lastNameTxt.TextChanged += TextChangedEvent;
            educationTxt.TextChanged += TextChangedEvent;
            ageList.TextChanged += TextChangedEvent;


            addButton.Enabled = false;

            foreach (var item in Enumerable.Range(1, 99))
            {
                ageList.Items.Add(item);
            }
            ageList.SelectedIndex = 17;

            manBtn.Checked = true;
            yesBtn.Checked = true;
            filterByAll.Checked = true;

            Text = "Опросник";

            dataList.Click += (s, e) =>
            {
                DataGridView dataGrid = s as DataGridView ?? new DataGridView();

                if (dataGrid.SelectedRows.Count != 0)
                {
                    firstNameTxt.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    secondNameTxt.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                    lastNameTxt.Text = dataGrid.SelectedRows[0].Cells[2].Value.ToString();

                    if (dataGrid.SelectedRows[0].Cells[3].Value.ToString() == "М")
                        manBtn.Checked = true;
                    else
                        womanBtn.Checked = true;

                    ageList.Text = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                    educationTxt.Text = dataGrid.SelectedRows[0].Cells[5].Value.ToString();

                    questionTxt.Text = dataGrid.SelectedRows[0].Cells[6].Value.ToString();
                }
            };

            filterByAll.CheckedChanged += (s, e) =>
            {
                if (filterByAll.Checked)
                    SetFilter(FilterMode.All);
            };

            filterByYes.CheckedChanged += (s, e) =>
            {
                if (filterByYes.Checked)
                    SetFilter(FilterMode.ByYes);
            };

            filterByNo.CheckedChanged += (s, e) =>
            {
                if (filterByNo.Checked)
                    SetFilter(FilterMode.ByNo);
            };
        }

        private void TextChangedEvent(object? sender, EventArgs e)
        {
            TextBox? textBox = (sender as TextBox);

            if (textBox is null)
                return;

            if (firstNameTxt.Text == string.Empty ||
                secondNameTxt.Text == string.Empty ||
                educationTxt.Text == string.Empty ||
                !int.TryParse(ageList.Text, out int _))
                addButton.Enabled = false;
            else
                addButton.Enabled = true;

            if (textBox.Text != string.Empty && textBox.Name != nameof(ageList))
            {
                textBox.Text = new string(textBox.Text.Where(c => !char.IsNumber(c)).ToArray());
                textBox.SelectionStart = textBox.TextLength;
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                Answer answer = null!;

                if (yesBtn.Checked)
                    answer = new(AnswerValues.Yes);
                else if (noBtn.Checked)
                    answer = new(AnswerValues.No);
                else
                    answer = new(AnswerValues.NoAnswer);

                Survey survey = new(
                    new Interviewee(
                        firstNameTxt.Text,
                        secondNameTxt.Text,
                        lastNameTxt.Text,
                        manBtn.Checked ? 'М' : 'Ж',
                        Convert.ToInt32(ageList.Text),
                        educationTxt.Text),
                    new Question(questionTxt.Text),
                    answer);

                surveys.Add(survey);

                firstNameTxt.Clear();
                secondNameTxt.Clear();
                lastNameTxt.Clear();
                educationTxt.Clear();

                dataList.Rows.Clear();

                for (int i = surveys.Count - 1; i >= 0; i--)
                {
                    dataList.Rows.Add(surveys[i].FieldsArray);
                }

                dataList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При добавлении записи что-то пошло не так: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (surveys.Count == 0)
                return;

            if (MessageBox.Show("Хотите сохранить данные?", "Сохранить?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SurveysDataHelper.SaveData(surveys);
            }
        }

        private void SetFilter(FilterMode filter)
        {
            List<Survey> filteredList;
            switch (filter)
            {
                case FilterMode.All:
                    dataList.Rows.Clear();
                    for (int i = surveys.Count - 1; i >= 0; i--)
                    {
                        dataList.Rows.Add(surveys[i].FieldsArray);
                    }
                    break;
                case FilterMode.ByYes:
                    dataList.Rows.Clear();
                    filteredList = surveys.Where(i => i.Answer.AnswerValue == AnswerValues.Yes).ToList();
                    for (int i = filteredList.Count - 1; i >= 0; i--)
                    {
                        dataList.Rows.Add(filteredList[i].FieldsArray);
                    }
                    break;
                case FilterMode.ByNo:
                    dataList.Rows.Clear();
                    filteredList = surveys.Where(i => i.Answer.AnswerValue == AnswerValues.No).ToList();
                    for (int i = filteredList.Count - 1; i >= 0; i--)
                    {
                        dataList.Rows.Add(filteredList[i].FieldsArray);
                    }
                    break;
                default:
                    dataList.Rows.Clear();
                    for (int i = surveys.Count - 1; i >= 0; i--)
                    {
                        dataList.Rows.Add(surveys[i].FieldsArray);
                    }
                    break;
            }
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            surveys = SurveysDataHelper.LoadData().ToList();
            if (surveys != null)
            {
                dataList.Rows.Clear();
                for (int i = surveys.Count - 1; i >= 0; i--)
                {
                    dataList.Rows.Add(surveys[i].FieldsArray);
                }
            }
        }

        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e) => SurveysDataHelper.SaveDataAs(surveys);

        private void ExitToolStripMenuItemClick(object sender, EventArgs e) => Close();

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using EmailSendForm emailForm = new()
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            emailForm.ShowDialog();
        }

        private void CheckIncomingToolStripMenuItemClick(object sender, EventArgs e)
        {
            using InboxEmailForm inboxEmailForm = new()
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            inboxEmailForm.ShowDialog();
        }
    }
}
