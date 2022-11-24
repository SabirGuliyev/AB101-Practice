using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_23.NewFolder
{
    internal record Animal
    {
        string _gender;
        int _birthYear;

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }

        }
        public int BirthYear
        {
            get
            {
                return _birthYear;
            }
            init
            {
                _birthYear = value;
            }
        }

        public Animal(string gender)
        {
            Gender = gender;
            BirthYear = DateTime.Now.Year;
        }
        
    }
}
