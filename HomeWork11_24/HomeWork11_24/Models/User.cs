using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_24.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private bool _isSignedIn;
        private Product[] _products;

        public string Username
        {
            get { return _username; }
            set 
            {
                if (value.Trim().Length>=6 && value.Trim().Length<=25)
                {
                    _username = value.Trim();
                } 
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            {
                if (value.Length>=8 && value.Length<=25)
                {
                    if (CheckPassword(value))
                    {
                        _password = value;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong size");
                }
               
            }
        }

        public Product[] Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public User(string username,string password)
        {
            Password=password;
            Username = username;
            _isSignedIn = false;
            _products = new Product[0];

        }
        public void Add(Product product)
        {
            if (_isSignedIn==true)
            {
                Array.Resize(ref _products, Products.Length + 1);
                Products[Products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("Please sign in:");
                Login();
            }

        }

        public void Login()
        {
            string username = Console.ReadLine().Trim();
            string password = Console.ReadLine();
            if (username==Username&&password==Password)
            {
                _isSignedIn = true;
         
            }
        }

        public bool CheckPassword(string password)
        {
            bool digit = false;
            bool upper=false;
            bool lower=false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digit = true;
                }
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
            }
            if (digit&&upper&&lower)
            {
                return true;
            }
            
            return false;
        }



    }
}
