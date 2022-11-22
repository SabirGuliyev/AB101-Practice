using HomeWork11_22.Models;

namespace HomeWork11_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group AB101 = new Group("AB101")
            {
                StudentLimit = 7
            };


        Student st = new Student("Tarlan", "Heydarov", 100);

        AB101.AddStudent(st);

         Student[] filterSt =   AB101.FilterByName("e");

            foreach (Student stu in filterSt)
            {
                Console.WriteLine(stu.Name + " " + stu.Surname);
            }


        }
    }
}