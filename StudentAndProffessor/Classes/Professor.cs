namespace StudentAndProffessor.Classes
{
    public class Professor : Person
    {
        protected int id;
        static int counter = 0;

        public int Id                                       // Присваиваем свой Id для идентификации
        {
            get { return id; }
        }

        public int Publication { get; set; }                // Количество публикаций

        public enum Pos
        {
            Teacher,
            SeniorTeacher,
            Docent,
            Professor
        }

        public Pos Position { get; set; }                   // Должность (тип - перечисление)

        public int Age { get; set; }                        // Возраст

        public int CountStudent { get; set; }               // Количество студентов у преподавателя

        public Professor(string firstName, string lastName, string lastName2, Pos position, int age) : base(firstName, lastName, lastName2)
        {
            Position = position;
            Age = age;

            id = ++counter;
        }

        // Переопределенный метод отображения
        public override string ShowData()
        {
            string st= FirstName + " " + LastName + " " + LastName2 + " " + "Публикаций: " + Publication.ToString() + " ";

            switch (Position)
            {
                case Pos.Teacher:                    
                    st= st + "Преподаватель";
                    break;
                    
                case Pos.SeniorTeacher:                    
                    st= st + "Старший преподаватель";
                    break;
                    
                case Pos.Docent:                    
                    st= st + "Доцент";
                    break;
                    
                case Pos.Professor:                    
                    st= st + "Профессор";
                    break;
            }

            return st + " " + "Возраст: " + Age.ToString()+ " " + "Студентов:" + CountStudent.ToString();
        }
    }
}
