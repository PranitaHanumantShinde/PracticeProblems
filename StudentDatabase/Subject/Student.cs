using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Student
    {
        private String _StudentName;
        private int _StudentId;
        private List<Subject> _SubjectInList;
        static int id;

        internal List<Subject> SubjectInList
        {
            get
            {
                return _SubjectInList;
            }

            set
            {
                _SubjectInList = value;
            }
        }

        public string StudentName
        {
            get
            {
                return _StudentName;
            }

            set
            {
                _StudentName = value;
            }
        }

        public int StudentId
        {
            get
            {
                return _StudentId;
            }

            set
            {
                _StudentId = value;
            }
        }

        public Student(String name,List<Subject> NewSubject)
        {
            _StudentId = ++id;
            _StudentName = name;
            _SubjectInList = NewSubject;
        }

        public override string ToString()
        {
            return _StudentId + " " + _StudentName + "" + _SubjectInList;
        }
    }
}
