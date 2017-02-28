using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Subject
    {
        private String _Subjectname;
        private int _ObtainedMarks;
        private int _TotalMarks;

        public Subject(String SubName,int ObtMarks,int totalmarks)
        {
            _Subjectname = SubName;
            _ObtainedMarks = ObtMarks;
            _TotalMarks = totalmarks;
        }

        public int ObtainMarks
        {
            get
            {
                return _ObtainedMarks;
            }
            set
            {
                _ObtainedMarks = value;
            }
        }

        public int TotalMarks
        {
            get
            {
                return _TotalMarks;
            }
            set
            {
                _TotalMarks = value;
            }
        }

        public String Subjectname
        {
            get
            {
                return _Subjectname;
            }
            set
            {
                _Subjectname = value;
            }
        }
        public override string ToString()
        {
            return " " + Subjectname + " " + ObtainMarks + " " + TotalMarks;
        }

    }
}
