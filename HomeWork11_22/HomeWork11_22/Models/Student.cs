using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_22.Models
{
    internal class Student
    {
        string _name;
        string _surname;
        byte _avgPoint;

        public Student(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public Student(string name, string surname, byte avgPoint)
        {
            _name = name;
            _surname = surname;
            _avgPoint = avgPoint;
        }

        public string Name { 
            get 
            { 
                return _name;
            } 
            set 
            {
                value = value.Trim();

                if (value.Length>0 && value.Length<30)
                    _name = value;
                else
                {
                    _name = "Wrong Input!";
                }
            } 
        }
        
        public string Surname { 
            get 
            { 
                return _surname;
            } 
            set 
            {
                value = value.Trim();

                if (value.Length>0 && value.Length<30)
                    _surname = value;
                else
                {
                    _surname= "Wrong Input!";
                }
            } 
        }

        public byte AvgPoint {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value>=0 && value<=100)
                {
                    _avgPoint= value;
                }
            }
        }
    }
}
