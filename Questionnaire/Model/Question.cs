namespace Questionnaire.Model
{
    public class Question
    {
        public string Text { get; set; } = null!;

        public Question()
        {
            
        }
        public Question(string text)
        {
            Text = text;
        }

        public override string ToString() => Text;
    }
}
