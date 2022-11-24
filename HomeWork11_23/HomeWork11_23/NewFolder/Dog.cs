using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_23.NewFolder
{
    internal record Dog:Animal
    {
        string _name;
        string _breed;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                _name = value;
            }
        }
        public string Breed
        {
            get
            {
                return _breed;
            }
            init
            {
                _breed = value;
            }
        }

        public Dog(string name, string breed,string gender):base(gender)
        {
            (Name,Breed)=(name,breed);
        }
        
    }
}
