using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12_09
{
    internal class Helper
    {

        public static void ForJson(object? obj,string path)
        {
            if (obj == null) return;

            string json = JsonConvert.SerializeObject(obj);
            //if (!File.Exists(path))
            //{
            //    using (File.Create(path)) { }

            //}
            WriteJson(path,json);
        }

        public static void WriteJson(string path,string str)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(str);
            }
        }

    }
}
