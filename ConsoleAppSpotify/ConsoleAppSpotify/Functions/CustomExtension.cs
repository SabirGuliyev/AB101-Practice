using ConsoleAppSpotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSpotify.Functions
{
    internal static class CustomExtension
    {
        public static bool CheckUsername(this string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length<6 || username.Length>12)
            {
                Console.Clear();
                Console.WriteLine("Username has to contain at least 6 and maximum 12 characters");
                return false;
            }
            if (username[0] == '.' || username[username.Length - 1] == '.') 
            {
                Console.Clear();
                Console.WriteLine("First and last character can not be .");
                return false;
            } 
         
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetterOrDigit(username[i]) && username[i] != '_' && username[i] != '.')
                {
                    Console.Clear();
                    Console.WriteLine("Username has to contain only letters or digits or . or _");
                    return false;
                }
            }
            User existed = username.FindUser();
            if (existed != null)
            {
                Console.Clear();
                Console.WriteLine("User with this username is already exists");
            }
            return true;
        }
        public static bool CheckPassword(this string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.Length > 12)
            {
                Console.Clear();
                Console.WriteLine("Password has to contain at least 6 and maximum 12 characters");
                return false;
            }

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
                    lower= true;
                }
            }
            if (upper && lower && digit) return true;
            Console.Clear();
            Console.WriteLine("Password has to contain at least 1 digit, 1 upper letter and 1 lower letter");
            return false;
        }
        public static string Capitalize(this string name)
        {
            name = name.Trim().ToLower();
            StringBuilder builder = new StringBuilder();
            builder.Append(char.ToUpper(name[0]));

            for (int i = 1; i < name.Length; i++)
            {
                builder.Append(name[i]);
            }
            return builder.ToString();
        }
        public static User FindUser(this string username)
        {
            return User._allUsers.Find(u => u.Username == username);
        }
    }
}
