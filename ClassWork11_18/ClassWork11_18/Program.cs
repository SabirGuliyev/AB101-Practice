

using ClassWork11_18.Models;

namespace ClassWork11_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person=new Person("Terlan","Heydarov",19);

            Student student = new Student("Terlan", "Heydarov", 19,"ab101");

            Console.WriteLine(person.Name);
            Console.WriteLine(student.Group);
        }

    }
}