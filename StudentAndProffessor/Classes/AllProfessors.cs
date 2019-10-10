namespace StudentAndProffessor.Classes
{
    public class AllProfessors<T> where T : Professor
    {
        public T[] professors;                                          // Список предодавателей

        // Метод добавления преподавателей
        public void Add(Professor st)                                   
        {
            T newProfessor = null;

            newProfessor = st as T;

            if (professors == null)
            {
                professors = new T[] { newProfessor };
            }
            else
            {
                T[] tempProfessors = new T[professors.Length + 1];

                for (int i = 0; i < professors.Length; i++)
                {
                    tempProfessors[i] = professors[i];
                }

                tempProfessors[tempProfessors.Length - 1] = newProfessor;

                professors = tempProfessors;
            }
        }
    }
}
