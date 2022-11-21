using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_21_2.Models
{
    internal class Group
    {
        public string GroupName;
        public Student[] Students;
        public Group(string groupname)
        {
            this.GroupName = groupname;

            Students = new Student[0];
        }


        public void Add(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length-1] = student;  
        }




        public void GetAll()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"{Students[i].Name} {Students[i].Surname}");
            }
        }
        public void GetOnlineStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].IsOnline==true)
                {
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname} {Students[i].IsOnline}");
                }
            }
        }
        public void GetOfflineStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].IsOnline == false)
                {
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname} {Students[i].IsOnline}");
                }
            }
        }
    }
}
