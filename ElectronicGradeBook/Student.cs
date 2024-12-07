using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicGradeBook
{
    internal class Student
    {
        public string Name { get; set; }
        public float GPA { get; set; }

        // Input 
        public void Input()
        {
            Console.Write("Enter student name: ");
            Name = Console.ReadLine();
            while (true)
            {
                Console.Write("Enter student GPA: ");
                GPA = float.Parse(Console.ReadLine());
                if (GPA >= 0 && GPA <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("GPA must be between 0 and 100");
                }
            }
        }
        // Output
        public void Output()
        {
            Console.WriteLine("Student name: " + Name);
            Console.WriteLine("Student GPA: " + GPA);
        }
    }
}
