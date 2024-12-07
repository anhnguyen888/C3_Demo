using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();
            gradeBook.Input();
            gradeBook.Output();
            Console.WriteLine("Average GPA: " + gradeBook.GetAverageGPA());
            Console.WriteLine("Highest GPA: " + gradeBook.GetHighestGPA());
            Console.WriteLine("Lowest GPA: " + gradeBook.GetLowestGPA());
            Console.WriteLine("Number of students with highest GPA: " + gradeBook.GetNumberOfStudentsWithHighestGPA());

            Console.WriteLine("Students with highest GPA:");

            foreach (Student student in gradeBook.GetStudentsWithHighestGPA())
            {
                student.Output();
            }
            Console.ReadLine();

        }
    }
}
