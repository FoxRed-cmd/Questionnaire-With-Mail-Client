using System.Text.Json.Serialization;

namespace Questionnaire.Model
{
    public class Interviewee
    {
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public char Gender { get; set; }
        public int Age { get; set; }
        public string Education { get; set; } = null!;
        public Interviewee()
        {
            
        }
        
        public Interviewee(string firstName, string secondName, string lastName, char gender, int age, string education)
        {
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Education = education;
        }
    }
}
