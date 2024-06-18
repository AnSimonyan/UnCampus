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
        private int _numberOfStudents { get; set; }
        private string _name { get; set; }

        /// <summary>
        /// Campus class declaration
        /// </summary>
        /// <param name="nameOfCampus"></param>
        public Campus(string nameOfCampus)
        {
            _name = nameOfCampus;
        }

        /// <summary>
        /// Display students quantity
        /// </summary>
        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetNameOfStudent());
            }
        }

        /// <summary>
        /// Add a new student in campus
        /// </summary>
        /// <param name="newStudent"></param>
        public void AddStudent(Student newStudent)
        {
            Array.Resize(ref students, _numberOfStudents+1);
            students[_numberOfStudents] = newStudent;
            _numberOfStudents++;
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
            if (_numberOfStudents != 0) result = sumOfNotesByCampus / _numberOfStudents;

            return result;
        }
    }
}

