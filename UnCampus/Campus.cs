using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnCampus
{
    internal class Campus
    {
        public Student[] students;
        public int NumberOfStudents { get; set; }
        public string Name { get; set; }



        public Campus(string nameOfCampus)
        {
            Name = nameOfCampus;

        }

        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
        public void AddStudent(Student newStudent)
        {
            NumberOfStudents++;
            Array.Resize(ref students, NumberOfStudents);
            students[NumberOfStudents - 1] = newStudent;

        }
        public double  GetCampusAverage()
        {   
            double sumOfNotesByCampus = 0; double result = 0;

            foreach (Student student in students)
            {
                sumOfNotesByCampus = sumOfNotesByCampus + student.GetAvarageOfStudent();
            }
            if (NumberOfStudents != 0) result = sumOfNotesByCampus / NumberOfStudents;

            return result;
        }
    }
}

