namespace UnCampus
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            Campus newCampus = new Campus("Camp1");
            Student newStudent = new Student("Student1", [20,20,30]);
            newCampus.AddStudent(newStudent);
            Student newStudent1 = new Student("Student2", [15,15,15]);
            newCampus.AddStudent(newStudent1);

            newCampus.DisplayStudents();
            Console.WriteLine(newCampus.GetCampusAverage());
        }
    }
}
