using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_23
{
    internal class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            { 
                if (value.Trim().Length>=6 && value.Trim().Length <= 25) 
                {
                    _username = value.Trim();
                }
                
            }
        }

        public string Password
        {
            get { return _password; }
            set {
                if (value.Length>=8 && value.Length<=25 && CheckPassword(value))
                {
                   _password = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        public User(string username)
        {
            Username= username;
        }


        public bool CheckPassword(string password)
        {
            bool digit = false;
            bool upper = false;
            bool lower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digit = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
            }

            if (digit && upper && lower)
            {
                return true;
            }
            //return (digit,upper,lower);
            
            return false;
        }

    }
}
