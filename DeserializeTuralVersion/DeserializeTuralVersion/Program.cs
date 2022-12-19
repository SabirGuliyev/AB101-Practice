using Newtonsoft.Json;

namespace DeserializeTuralVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Tural");
            list.Add("Ramal");
            list.Add("Elxan");
            list.Add("Yene Tural");

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string path =Path.Combine(Directory.GetCurrentDirectory(),"../../../","Files");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, "names.json");

            //File.Create(path).Close();
            //using (File.Create(path)){ }

            using (StreamWriter sw = new StreamWriter(path))
            {
                string json = JsonConvert.SerializeObject(list);
                sw.Write(json);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                List<string> json = JsonConvert.DeserializeObject<List<string>>(sr.ReadToEnd());
                foreach (var item in json)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}