using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>(); ;
            
            Registration.RegisterNewStudent(studentsList);

            Console.WriteLine("Enter the name to see the records");
            string name = Console.ReadLine();
          IEnumerable<Students> list=  studentsList.Where(s=> s.StudentName==name);
           foreach(Students student in list)
            {
                Console.WriteLine(student);

            }



        }
    }
}
