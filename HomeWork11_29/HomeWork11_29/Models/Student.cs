using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_29.Models
{
    internal class Student
    {
        public static int Count = 0;
        int _id;
        string _fullname;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        static Student()
        {
            Console.WriteLine("Birinci ve axrinci sefer ishe dushurem");
        }
        public Student(string fullname)
        {
            Count++;
            Id = Count;
            Fullname = fullname;
        }
        public static bool CheckFullname(string fullname)
        {
            string[] parts=fullname.Trim().Split(' ');

            if (parts.Length!=2)
            {
                return false;
            }

            for (int i = 0; i < parts.Length; i++)
            {
                if (!char.IsUpper(parts[i][0]) || parts[i].Length<3)
                {
                    return false;
                }
                for (int j = 1; j < parts[i].Length; j++)
                {
                    if (!char.IsLower(parts[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
