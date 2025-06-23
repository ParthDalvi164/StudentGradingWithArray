using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class StudentManager
    {
        public static Student[] students = new Student[3];

        public static int count = 0;
        public void AddStudentMan()
        {
            int indx = students.Length;

            if (count < indx)
            {
                students[count] = new Student();
                count++;
            }
            else
            {
                Console.WriteLine("Array is full!");
            }
        }

        public void DisplayReportMan()
        {
            Console.Write("Enter the student's roll number whose report card is to be printed : ");
            string userResp = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].StudentId == userResp)
                {
                    students[i].printReport();
                    return;
                }
            }
            Console.WriteLine("Student with this roll number does not exist!");
        }
    }
}
