namespace StudentAndProffessor.Classes
{
    public class Student:Person
    {
        protected int id;
        static int counter = 0;

        public int Id                                   // Присваиваем свой Id для идентификации
        {
            get { return id; }
        }

        public double Average { get; set; }             // Средний балл

        public int IdSupervisor { get; set; }           // Ссылка на Руководителя

        public Student(string firstName, string lastName, string lastName2, int idsupervisor, double _average=0) : base(firstName, lastName, lastName2)
        {
            IdSupervisor = idsupervisor;
            
            Average = _average;

            id = ++counter;
        }

        // Переопределенный метод отображения
        public override string ShowData()
        {
            return FirstName + " " + LastName + " " + LastName2 + " " + "Средний балл: " + Average.ToString();
        }
    }
}
