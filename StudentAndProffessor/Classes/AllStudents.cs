namespace StudentAndProffessor.Classes
{
    public class AllStudents<T> where T:Student
    {
        public T[] students;                                                // Список студентов

        // Метод добавления студентов
        public void Add(Student st)
        {
            T newStudent = null;

            newStudent = st as T;

            if (students==null)
            {
                students = new T[] { newStudent };
            }
            else
            {
                T[] tempStudents = new T[students.Length + 1];

                for (int i=0; i<students.Length; i++)
                {
                    tempStudents[i] = students[i];
                }

                tempStudents[tempStudents.Length - 1] = newStudent;

                students = tempStudents;
            }
        }
    }
}
