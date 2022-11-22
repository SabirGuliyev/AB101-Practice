using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_22.Models
{
    internal class Group
    {
        string _no;
        byte _studentLimit;
        Student[] _students;
        public Student[] Students { get { return _students; } set { _students = value; } }
        

        public string No
        {
            get
            {
                return _no;
            }
            set {
                value = value.Trim();
                string StrArea = value.Substring(0, 2);
                string NumArea = value.Substring(2);
                bool IsNum = byte.TryParse(NumArea, out _);
                if (IsUpper(StrArea) && IsNum && NumArea.Length == 3)
                {
                    _no = value;
                }

                else
                {
                    _no = "Wrong Input!";
                }

            }
        }

        public byte StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (_studentLimit >= 5 && _studentLimit <= 18)
                {
                    _studentLimit = value;
                }

                else if (_studentLimit < 5)
                    _studentLimit = 5;
                else
                    _studentLimit = 18;
            }
        }


        public Group(string no)
        {
            No=no;
            Students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public Student[] FilterByName(string key)
        {
            Student[] FilterStudents = new Student[0];

            key = key.ToLower();

            foreach (Student st in Students)
            {
                bool have = (st.Name +" "+ st.Surname).ToLower().Contains(key);

                if (have)
                {
                    //string name = Console.ReadLine().Trim().ToLower();
                    Array.Resize(ref FilterStudents, FilterStudents.Length + 1);    
                    FilterStudents[FilterStudents.Length - 1] = st;
                }
            }
            return FilterStudents;
        }
        private static bool IsUpper(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
