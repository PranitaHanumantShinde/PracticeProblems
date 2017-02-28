using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Registration
    {
        private List<Subject> FillSubjectList()
        {
            List<Subject> TempList = new List<Subject>(4);
            int Count = 4;
            Console.WriteLine("Enter SubjectDetails:");
            while(Count!=0)
            {
                Console.WriteLine("Enter SubjectName:");
                String SubjectName = Console.ReadLine();
                Console.WriteLine("Enter ObtainedMarks:");
                int ObtainedMarks=Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter TotalMarks");
                int TotalMarks = Convert.ToInt32(Console.ReadLine());
                TempList.Add( new Subject(SubjectName, ObtainedMarks, TotalMarks));
                Count--;
            }
            return TempList;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter name of Student");
            String Name = Console.ReadLine();
            Registration r = new Registration();
            Student s = new Student(Name, r.FillSubjectList());

        }
    }
}
