using HomeWork11_29.Models;

namespace HomeWork11_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fullname daxil edin");
            CheckPoint:
            string fullname = Console.ReadLine().Trim();
            if (Student.CheckFullname(fullname))
            {
                
                Student student = new Student(fullname);
                
                Console.WriteLine($"ID:{student.Id}\nFullname:{student.Fullname}" +
                    $"\n\nCount:{Student.Count}");
                Student student1 = new Student(fullname);
                Console.WriteLine($"ID:{student1.Id}\nFullname:{student1.Fullname}" +
                    $"\n\nCount:{Student.Count}");
                Student student2 = new Student(fullname);
                Console.WriteLine($"ID:{student2.Id}\nFullname:{student2.Fullname}" +
                    $"\n\nCount:{Student.Count}");
            }
            else
            {
                Console.WriteLine("Wrong input please try again");
                goto CheckPoint;
            }












            //Student student = new Student("dsfsdf");
            //student.Check("dvds");
        }
    }
}