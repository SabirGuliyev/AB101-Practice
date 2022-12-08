namespace ClassWorkSystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), @"../../../", "AB101");

            Directory.CreateDirectory(path);
            File.Create(Path.Combine(path,"Student.cs"));
        }
    }
}