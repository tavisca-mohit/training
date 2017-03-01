using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Validation
    {
        internal static bool ValidateInput(string studentName,string subjectName,string totalMarks,string obtainedMarks)
        {
            bool check1 = isEmpty(studentName, subjectName, totalMarks, obtainedMarks);
            if(!check1)
            {
                return false;
            }
            bool check2 = isValidName(studentName, subjectName);
            if(!check2)
            {
                return false;
            }
            bool check3 = isValidMarks(totalMarks, obtainedMarks);
            if (!check3)
            {
                return false;
            }
            return true;


        }
        private static bool isEmpty(string studentName,string subjectName,string totalMarks,string obtainedMarks)
        {
            if(studentName.Length==0)
            {
                Console.WriteLine("name cannot be empty");
                return false;
            }
            else if(subjectName.Length==0)
            {
                Console.WriteLine("Subject cannot be empty");
                return false;
            }
            else if(totalMarks.Length==0)
            {
                Console.WriteLine("totalmarks cannot be empty");
                return false;
            }
            else if(obtainedMarks.Length==0)
            {
                Console.WriteLine("obtained marks cannot be empty");
                return false;
            }
            return true;
        }
        private static bool isValidName(string studentName,string subjectName)
        {
            foreach(char character in studentName)
            {
                if(!Char.IsLetter(character))
                {
                    Console.WriteLine("Studentname is not valid");
                    return false;
                }
            }
            foreach (char character in subjectName)
            {
                if (!Char.IsLetter(character))
                {
                    Console.WriteLine("Subjectname is not valid");
                    return false;
                }
            }
            return true;
        }
        private static bool isValidMarks(string totalMarks,string obtainedMarks)
        {
            foreach(char character in totalMarks)
            {
                if(!(character>=48 && character<=57))
                {
                    Console.WriteLine("totalmarks are not valid");
                    return false;
                }

            }
            foreach (char character in obtainedMarks)
            {
                if (!(character >= 48 && character <= 57))
                {
                    Console.WriteLine("obtainedMarks are not valid");
                    return false;
                }

            }

            if(int.Parse(totalMarks)< int.Parse(obtainedMarks))
            {
                Console.WriteLine("obtained marks cannot be greater than total marks");
                return false;
            }
            return true;
        }
    }
}
