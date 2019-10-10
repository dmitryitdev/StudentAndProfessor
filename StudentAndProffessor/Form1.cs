using StudentAndProffessor.Classes;
using System;
using System.Windows.Forms;

namespace StudentAndProffessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();

            CreateList();
        }
        
        AllStudents<Student> students = new AllStudents<Student>();
        AllProfessors<Professor> professors = new AllProfessors<Professor>();

        private void btbAddStudent_Click(object sender, EventArgs e)
        {
            double Average;

            if (Double.TryParse(txtStudentAverage.Text, out Average))
            {
                Student st = new Student(txtStudentFirstName.Text, txtStudentLastName.Text, txtStudentLastName2.Text, cmbSupervisor.SelectedIndex, Average);

                if (cmbSupervisor.SelectedIndex != -1)
                {
                    professors.professors[cmbSupervisor.SelectedIndex].CountStudent++;
                }

                students.Add(st);                
            }
            else
            {
                MessageBox.Show("Ошибка при вводе среднего балла!");
            }
        }

        private void btbAddProfessor_Click(object sender, EventArgs e)
        {
            int Age;
            int Publication;

            Professor.Pos pos = Professor.Pos.Teacher;

            if (Int32.TryParse(txtProfessorPublication.Text, out Publication))
            {
                if (Int32.TryParse(txtProfessorAge.Text, out Age))
                {
                    switch (cmbPosition.SelectedIndex)
                    {
                        case 0:
                            pos= Professor.Pos.Teacher;
                            break;
                        case 1:
                            pos= Professor.Pos.SeniorTeacher;
                            break;
                        case 2:
                            pos= Professor.Pos.Docent;
                            break;
                        case 3:
                            pos= Professor.Pos.Professor;
                            break;
                    }

                    Professor pr = new Professor(txtProfessorFirstName.Text, txtProfessorLastName.Text, txtProfessorLastName2.Text, pos, Age);
                    
                    professors.Add(pr);


                    // Формируем выпадающий список преподавателей                    
                    for (int i = 0; i < professors.professors.Length; i++)
                    {
                        cmbSupervisor.Items.Add(professors.professors[i].FirstName + " " + professors.professors[i].LastName + " " + professors.professors[i].LastName2);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе возраста!");
                }
            }
            else
            {
                MessageBox.Show("Ошибка при вводе количества публикаций!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPosition.Items.Add("Преподаватель");
            cmbPosition.Items.Add("Старший преподаватель");
            cmbPosition.Items.Add("Доцент");
            cmbPosition.Items.Add("Профессор");

            cmbPosition.SelectedIndex = 0;
        }

        private void CreateList()
        {
            lstInfo.Items.Clear();

            if (students.students!=null)
            { 
                for (int i = 0; i < students.students.Length; i++)
                {
                    lstInfo.Items.Add(students.students[i].ShowData());
                }
            }

            if (professors.professors != null)
            {
                for (int i = 0; i < professors.professors.Length; i++)
                {
                    lstInfo.Items.Add(professors.professors[i].ShowData());
                }
            }
        }        
    }
}
