using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StringArray
    {
        string[] _arr;
        public string this[int i] 
        { 
            get
            {
                if (!(i<_arr.Length))
                {
                    throw new ArgumentException();
                }
                return _arr[i];
            } 
            set 
            {
                if (!(i < _arr.Length))
                {
                    throw new ArgumentException();
                }
                _arr[i]=value;
            }
        }
        public StringArray()
        {
            _arr = new string[0];
        }
        public StringArray(int length)
        {
            _arr = new string[length];
        }
         
    }
}
