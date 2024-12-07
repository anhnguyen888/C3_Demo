using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    internal class GradeBook
    {
        private List<Student> students = new List<Student>();

        // Input
        public void Input()
        {
            while (true)
            {
                Student student = new Student();
                student.Input();
                students.Add(student);
                Console.Write("Do you want to add another student? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }
        // Output
        public void Output()
        {
            foreach (Student student in students)
            {
                student.Output();
            }
        }

        // Get average GPA
        public float GetAverageGPA()
        {
            return students.Average(student => student.GPA);
        }
        // Get highest GPA
        public float GetHighestGPA()
        {
            return students.Max(student => student.GPA);
        }
        // Get lowest GPA
        public float GetLowestGPA()
        {
            return students.Min(student => student.GPA);
        }
        // Get number of students with highest GPA
        public int GetNumberOfStudentsWithHighestGPA()
        {
            return students.Count(student => student.GPA == GetHighestGPA());
        }
        // Get students with highest GPA
        public List<Student> GetStudentsWithHighestGPA()
        {
            return students.Where(student => student.GPA == GetHighestGPA()).ToList();
        }
    }
}
