using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnCampus
{
    internal class Student
    {
        public string Name { get; }
        public double[] Notes { get; }

        public Student(string studentName, double[] notes)
        {
            Name = studentName;
            Notes = notes;
        }

        public void TalkWithAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(Name + "talk with " + interlocutor.Name);
        }

        public void YellingAtAnotherStudent(Student interlocutor)
        {
            Console.WriteLine(Name + "yell at " + interlocutor.Name);
        }

        public double GetAvarageOfStudent()
        {
            double result = 0;
            if (Notes.Length !=) result = Notes.Sum() / Notes.Length;
            return result;
        }
    }
}
