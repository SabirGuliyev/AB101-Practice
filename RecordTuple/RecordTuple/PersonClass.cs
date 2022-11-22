using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTuple
{
    internal class PersonClass
    {
        public string Name;
        public string Surname;
        public (string,string) FullName {
            get
            {
                return (Name, Surname);
            }



            set { } }
        public PersonClass(string name, string surname)
        {
            //Name = name;
            //Surname = surname;

            (Name, Surname) = (name, surname);
        }
    }
    //internal record PersonRecord
    //{
    //    string _name;
    //    string _surname;
    //    byte _age;
    //    string _gender;
    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
    //    public string Surname
    //    {
    //        get { return _surname; }
    //         init { _surname = value; }
    //    }

    //    public PersonRecord(string name, string surname,byte age,string gender)
    //    {
    //       (Name,Surname,_age,_gender) =(name,surname,age,gender);

    //    }
    //}
    //internal record PersonRecord(string Name,string Surname);
}
