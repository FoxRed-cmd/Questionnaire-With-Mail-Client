using Questionnaire.Model;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Xml;
using System.Xml.Serialization;

namespace Questionnaire.Helpers
{
    public static class SurveysDataHelper
    {
        private static string dataPath = string.Empty;
        private static List<Survey> surveys = [];
        private static string filter = "object files (*.json;*.xml)|*.json;*.xml";
        public static IEnumerable<Survey> LoadData()
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
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                dataPath = openFileDialog.FileName;
                string extension = Path.GetExtension(dataPath);
                switch (extension)
                {
                    case ".json":
                        LoadJson();
                        break;
                    case ".xml":
                        LoadXml();
                        break;
                    default:
                        break;
                }
            }

            return surveys;
        }

        public static void SaveData(IEnumerable<Survey> data)
        {
            if (dataPath == string.Empty)
            {
                SaveDataAs(data);
            }
            else
            {
                surveys = data.ToList();
                string extension = Path.GetExtension(dataPath);
                switch (extension)
                {
                    case ".json":
                        SaveJson();
                        break;
                    case ".xml":
                        SaveXml();
                        break;
                    default:
                        dataPath += ".json";
                        SaveJson();
                        break;
                }
            }

        }

        public static void SaveDataAs(IEnumerable<Survey> data)
        {
            surveys = data.ToList();

            using SaveFileDialog saveFileDialog = new()
            {
                Filter = "json files (*.json)|*.json|xml files (*.xml)|*.xml",
                FilterIndex = 0,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Сохранить",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataPath = saveFileDialog.FileName;
                string extension = Path.GetExtension(dataPath);
                switch (extension)
                {
                    case ".json":
                        SaveJson();
                        break;
                    case ".xml":
                        SaveXml();
                        break;
                    default:
                        dataPath += ".json";
                        SaveJson();
                        break;
                }
            }
        }
        private static void SaveJson()
        {
            using StreamWriter streamWriter = new(dataPath);
            string jsonData = JsonSerializer.Serialize(surveys, new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                IncludeFields = true,
                WriteIndented = true,
            });
            streamWriter.WriteLine(jsonData);
        }
        private static void SaveXml()
        {
            using FileStream writer = new(dataPath, FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new(typeof(List<Survey>));
            xmlSerializer.Serialize(writer, surveys);
        }
        private static void LoadXml()
        {
            try
            {
                surveys.Clear();
                XmlDocument xmlDocument = new();
                xmlDocument.Load(dataPath);

                XmlElement? xRoot = xmlDocument.DocumentElement;
                if (xRoot != null && xRoot.HasChildNodes)
                {
                    foreach (XmlNode node in xRoot.ChildNodes)
                    {
                        ReadXml(node, null, null);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"При загрузке файла что-то пошло не так: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void ReadXml(XmlNode node, Survey? currentSurvey, Interviewee? currentInterviewee)
        {
            if (node is null)
                return;
            switch (node.Name)
            {
                case nameof(Survey):
                    currentSurvey = new Survey();
                    surveys.Add(currentSurvey);
                    break;
                case nameof(Interviewee):
                    currentInterviewee = new Interviewee();
                    if (currentSurvey is not null)
                        currentSurvey.Interviewee = currentInterviewee;
                    break;
                case "FirstName":
                    if (currentInterviewee is not null)
                        currentInterviewee.FirstName = node.InnerText;
                    break;
                case "SecondName":
                    if (currentInterviewee is not null)
                        currentInterviewee.SecondName = node.InnerText;
                    break;
                case "LastName":
                    if (currentInterviewee is not null)
                        currentInterviewee.LastName = node.InnerText;
                    break;
                case "Gender":
                    if (currentInterviewee is not null)
                        currentInterviewee.Gender = Convert.ToChar(int.Parse(node.InnerText));
                    break;
                case "Age":
                    if (currentInterviewee is not null)
                        currentInterviewee.Age = int.Parse(node.InnerText);
                    break;
                case "Education":
                    if (currentInterviewee is not null)
                        currentInterviewee.Education = node.InnerText;
                    break;
                case nameof(Question):
                    if (currentSurvey is not null)
                        currentSurvey.Question = new Question(node.FirstChild?.InnerText ?? "");
                    break;
                case nameof(Answer):
                    string answerText = node.FirstChild?.InnerText ?? "";
                    if (currentSurvey is not null)
                        currentSurvey.Answer = answerText switch
                        {
                            "Yes" => new Answer(AnswerValues.Yes),
                            "No" => new Answer(AnswerValues.No),
                            _ => new Answer(AnswerValues.NoAnswer),
                        };
                    break;
            }

            foreach (XmlNode nodeItem in node.ChildNodes)
            {
                ReadXml(nodeItem, currentSurvey, currentInterviewee);
            }
        }
        private static void LoadJson()
        {
            try
            {
                using StreamReader reader = new(dataPath);
                string data = reader.ReadToEnd();
                surveys = JsonSerializer.Deserialize<List<Survey>>(data) ?? [];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При загрузке файла что-то пошло не так: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
