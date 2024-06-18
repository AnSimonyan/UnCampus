using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnCampus
{
    internal class Student
    {
        private string _name { get; set; }
        private double[] _notes { get; set}

        /// <summary>
        /// Students class declaration
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="notes"></param>
        public Student(string studentName, double[] notes)
        {
            _name = studentName;
            _notes = notes;
        }

        /// <summary>
        /// Method talking displays a message 
        /// </summary>
        /// <param name="interlocutor"></param>
        public void TalkWithAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(_name + "talk with " + interlocutor._name);
        }

        /// <summary>
        /// Method yelling displays a message 
        /// </summary>
        /// <param name="interlocutor"></param>
        public void YellingAtAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(_name + "yell at " + interlocutor._name);
        }
        /// <summary>
        /// Returns the student's nots average 
        /// </summary>
        /// <returns></returns>
        public double GetAvarageOfStudent()
        {
            double result = 0;
            if (_notes.Length !=0) result = _notes.Average();
            return result;
        }
    }
}
