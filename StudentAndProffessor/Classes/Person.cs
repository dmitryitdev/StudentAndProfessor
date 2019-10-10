namespace StudentAndProffessor.Classes
{
    public class Person
    {        
        public string FirstName { get; set; }       // Фамилия

        public string LastName { get; set; }        // Имя

        public string LastName2 { get; set; }       // Отчество

        public Person(string _firstName, string _lastName, string _lastName2)
        {
            FirstName = _firstName;
            LastName = _lastName;
            LastName2 = _lastName2;
        }

        public virtual string ShowData()
        {
            return FirstName + " " + LastName + " " + LastName2;
        }
    }
}
