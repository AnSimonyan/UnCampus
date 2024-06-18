using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnCampus
{
    internal class Student
    {
        private string Name { get; set; }
        private double[] Notes { get; set}

        /// <summary>
        /// Students class declaration
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="notes"></param>
        public Student(string studentName, double[] notes)
        {
            Name = studentName;
            Notes = notes;
        }

        /// <summary>
        /// Method talking displays a message 
        /// </summary>
        /// <param name="interlocutor"></param>
        public void TalkWithAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(Name + "talk with " + interlocutor.Name);
        }

        /// <summary>
        /// Method yelling displays a message 
        /// </summary>
        /// <param name="interlocutor"></param>
        public void YellingAtAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(Name + "yell at " + interlocutor.Name);
        }
        /// <summary>
        /// Returns the student's nots average 
        /// </summary>
        /// <returns></returns>
        public double GetAvarageOfStudent()
        {
            double result = 0;
            if (Notes.Length !=0) result = Notes.Average();
            return result;
        }
    }
}
