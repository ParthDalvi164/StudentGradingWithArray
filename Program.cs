using StudentLibrary;
namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager s1 = new StudentManager();

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("-------- STUDENT APP --------");
                Console.WriteLine("1. Add Student \n2. Display report card \n3. Exit ");
                Console.Write("Choose your action : ");

                string userResp = Console.ReadLine();


                switch (userResp)
                {
                    case "1":
                        s1.AddStudentMan();
                        break;
                    case "2":
                        s1.DisplayReportMan();
                        break;
                    case "3":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
