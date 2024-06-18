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
        private int NumberOfStudents { get; set; }
        private string Name { get; set; }

        /// <summary>
        /// Campus class declaration
        /// </summary>
        /// <param name="nameOfCampus"></param>
        public Campus(string nameOfCampus)
        {
            Name = nameOfCampus;
        }

        /// <summary>
        /// Display students quantity
        /// </summary>
        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        /// <summary>
        /// Add a new student in campus
        /// </summary>
        /// <param name="newStudent"></param>
        public void AddStudent(Student newStudent)
        {
            NumberOfStudents++;
            Array.Resize(ref students, NumberOfStudents);
            students[NumberOfStudents - 1] = newStudent;
        }

        /// <summary>
        /// Returns the notes average of campus
        /// </summary>
        /// <returns></returns>
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

