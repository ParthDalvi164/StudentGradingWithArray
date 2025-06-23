using System.Numerics;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentLibrary
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public int[] StudentMarks { get; set; }
        public float Average {  get; set; }
        public string Grade { get; set; }

        public Student()
        {
            StudentMarks = new int[5];

            Console.Write("Enter name of the student : ");
            this.StudentName = Console.ReadLine();

            Console.Write("Enter roll number : ");
            this.StudentId = Console.ReadLine();

            Console.WriteLine("Enter marks of 5 subjects ->");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks of subject number {i + 1} : ");
                StudentMarks[i] = int.Parse(Console.ReadLine());
            }

            calculateAverage();
            calculateGrade();
        }

        public void calculateAverage()
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total = total + StudentMarks[i];
            }
            this.Average = total / 5;
        }

        public void calculateGrade()
        {
            if (this.Average >= 90)
            {
                this.Grade = "A";
            }
            else if (this.Average > 79 && this.Average < 90) 
            {
                this.Grade = "B";
            }
            else if (this.Average > 69 && this.Average < 80)
            {
                this.Grade = "C";
            }
            else if (this.Average > 59 && this.Average < 70)
            {
                this.Grade = "D";
            }
            else if (this.Average > 49 && this.Average < 60)
            {
                this.Grade = "E";
            }
            else
            {
                this.Grade = "FAIL";
            }
        }

        public void printReport()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------- STUDENT REPORT CARD --------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"NAME OF THE STUDENT : {this.StudentName} ");
            Console.WriteLine($"ROLL NUMBER OF THE STUDENT : {this.StudentId} ");
            Console.Write("MARKS OF THE STUDENT : [");
            foreach (int num in this.StudentMarks)
            {
                Console.Write(" " + num + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine($"AVERAGE OF THE STUDENT : {this.Average}");
            Console.WriteLine($"GRADE OF THE STUDENT : {this.Grade}");
        }
    }
}
