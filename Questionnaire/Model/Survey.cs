using System.Text.Json.Serialization;

namespace Questionnaire.Model
{
    public class Survey
    {
        public Interviewee Interviewee { get; set; } = null!;
        public Question Question { get; set; } = null!;
        public Answer Answer { get; set; } = null!;

        public Survey()
        {
            
        }
        public Survey(Interviewee interviewee, Question question, Answer answer)
        {
            Interviewee = interviewee;
            Question = question;
            Answer = answer;
        }

        [JsonIgnore]
        public string[] FieldsArray => [
            Interviewee.FirstName,
            Interviewee.SecondName,
            Interviewee.LastName,
            Interviewee.Gender.ToString(),
            Interviewee.Age.ToString(),
            Interviewee.Education,
            Question.Text,
            Answer.ToString(),
        ];

    }
}
