using System.Web.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12_09
{
    internal class Program
    {
         static string path = Path.Combine(@"C:\Users\sabir\OneDrive\Рабочий стол\AB101\HomeWork12_09\HomeWork12_09\Files","names.json");
        static void Main(string[] args)
        {


            List<string> stringlist = new List<string>();


            stringlist.Add("Elxan");
            stringlist.Add("Murad");
            stringlist.Add("Fateh");


            Helper.ForJson(stringlist,path);
            Add("Ulviyya");
        }
        static void Add(string name)
        {
            string str;
            using(StreamReader sr= new StreamReader(path))
            {
                str=sr.ReadToEnd();
            }
            //if(str!=null)
            //{

            //}
            List<string> list = JsonConvert.DeserializeObject<List<string>>(str);
            if (list==null)
            {
                list = new List<string>();
            }
            if(!list.Contains(name))
            {
                list.Add(name);
                Helper.ForJson(list, path);
            }
        }
        static bool Search(string name)
        {

        }
    }
}