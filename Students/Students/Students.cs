using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Students
    {
        static int id = 0;
        public int StudentID
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public List<Marks> Marks
        {
            get;
            set;
        }

        public Students(string StudentName,List<Marks> Marks)
        {
            StudentID = ++id;
            this.StudentName = StudentName;
            this.Marks = Marks;
        }

        public override string ToString()
        {
            StringBuilder marksString = new StringBuilder();
            foreach(Marks marks in Marks)
            {
                marksString.Append(marks);
            }
            return StudentID.ToString() + "\n" + StudentName + "\n" + marksString.ToString();
        }
    }
}
