using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Registration
    {
        internal static void RegisterNewStudent(List<Students> studentsList)
        {
            bool loop = true;

            do
            {
                string studentName;
                List<Marks> Marks = Input.GetNameAndMarks(out studentName);
                studentsList.Add(new Students(studentName, Marks));
                Console.WriteLine("To Register again press y");
                string checker = Console.ReadLine();
                if (!checker.Equals("y"))
                {
                    loop = false;
                }
            }
            while (loop == true);
        }

    }
}
