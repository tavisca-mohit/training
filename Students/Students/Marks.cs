using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Marks
    {
        public string SubjectName
        {
            get;
            set;
        }
        public int TotalMarks
        {
            get;
            set;
        }
        public int ObtainedMarks
        {
            get;
            set;
        }

        public Marks(string SubjectName,int TotalMarks,int ObtainedMarks)
        {
            this.SubjectName = SubjectName;
            this.TotalMarks = TotalMarks;
            this.ObtainedMarks = ObtainedMarks;

        }
        public override string ToString()
        {
            return "\n" + SubjectName + "\n" + ObtainedMarks + '/' + TotalMarks; 
        }
    }
}
