using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_30
{
    internal static class Extension
    {
        //public static bool IsEven(this uint number)
        //{
                
        //    if (number % 2 == 0 && number != 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public static bool IsOdd(this uint number)
        //{

        //    if (number % 2 == 0&&number!=0)
        //    {
        //        return false;
        //    }
        //    return true;   
        //}

        //public static bool HasDigit(this string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsDigit(str[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


        //public static string ToCapitalize(this string str)
        //{
        //    str = str.Trim();
        //    return char.ToUpper(str[0]) + str.Substring(1).ToString().ToLower();
        //}

        public static string ToCapitalizes(this string str)
        {
           
            
            if (string.IsNullOrEmpty(str)||string.IsNullOrEmpty(str.Trim()))
            {
                return null;
            }
            str = str.Trim();
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(str[0]));

           
            sb.Append(str.Substring(1).ToLower());
            
            return sb.ToString();
        }
    }
    
}
