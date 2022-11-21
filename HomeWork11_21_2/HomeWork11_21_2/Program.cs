using HomeWork11_21_2.Models;

namespace HomeWork11_21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Fateh", "Aliverdiev", 19, true);
            Student student1 = new Student("Elxan", "Cobra", 19, false);
            Student student2 = new Student("Terlan", "SiSAdmin", 19, true);
            Group group = new Group("AB101");
            group.Add(student);
            group.Add(student1);
            group.Add(student2);

            group.GetOnlineStudents();
        }
    }
}