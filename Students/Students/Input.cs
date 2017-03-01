using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Input
    {
        internal static List<Marks> GetNameAndMarks(out string StudentName)
        {
            StudentName = null;
            bool loop = true,isValid;
            List<Marks> Marks = new List<Marks>();
            while (loop == true)
            {
                do
                {
                    Console.WriteLine("Enter StudentName");
                    StudentName = Console.ReadLine().Trim();
                    Console.WriteLine("please enter Subject name");
                    string subjectName = Console.ReadLine().Trim();
                    Console.WriteLine("enter total marks");
                    string totalMarks = Console.ReadLine();
                    Console.WriteLine("enter obtained marks");
                    string obtainedMarks = Console.ReadLine();
                    isValid = Validation.ValidateInput(StudentName, subjectName, totalMarks, obtainedMarks);
                    if (isValid)
                    {

                        Marks.Add(new Marks(subjectName, int.Parse(totalMarks), int.Parse(obtainedMarks)));
                    }
                }
                while (isValid == false);
                Console.WriteLine("To add another subject press Y");
                string checker = Console.ReadLine();
                if (!checker.Equals("y"))
                {
                    loop = false;
                }
            }
            return Marks;
        }
    }
}
