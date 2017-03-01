using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Display
    {
        internal static void DisplayStudentsAndMarks(List<Students> studentsList)
        {
            foreach(Students student in  studentsList)
            {
                Console.WriteLine(student);
                Console.WriteLine("\n");
            }

        } 
    }
}
