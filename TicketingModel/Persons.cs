using Apttus.Assignment.MovieTicket.Enum;

namespace Apttus.Assignment.MovieTicket
{
    public class Persons
    {
        public Persons(string name, int age, Gender _gender)
        {
            Name = name;
            Age = age;
            gender = _gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
    }
}