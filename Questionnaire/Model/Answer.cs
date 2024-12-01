using System.Text.Json.Serialization;

namespace Questionnaire.Model
{
    public enum AnswerValues
    {
        Yes,
        No,
        NoAnswer,
    }

    public class Answer
    {
        public AnswerValues AnswerValue { get; set; }

        //[JsonConstructor]
        public Answer()
        {
            
        }
        public Answer(AnswerValues answerValue)
        {
            AnswerValue = answerValue;
        }

        public static bool operator ==(Answer a, Answer b) => a.AnswerValue.Equals(b.AnswerValue);

        public static bool operator !=(Answer a, Answer b) => !(a.AnswerValue.Equals(b.AnswerValue));

        public override bool Equals(object? obj)
        {
            return this.AnswerValue.Equals(obj as Answer);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return AnswerValue switch
            {
                AnswerValues.Yes => "Да",
                AnswerValues.No => "Нет",
                AnswerValues.NoAnswer => "Воздержался",
                _ => string.Empty,
            };
        }
    }
}
