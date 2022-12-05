using ClassWorkDelegate.Models;
using System.Text;

namespace ClassWorkDelegate
{
    delegate void RegisterEmployee( Employee employee);
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("sabir", "sabir.guliyev");
            RegisterEmployee register = new RegisterEmployee(Capitalize);
            register += CreateGmail;

            Console.WriteLine($"Before changes: name={employee.Name} gmail={employee.Gmail}");

            register.Invoke( employee);

            Console.WriteLine($"After changes: name={employee.Name} gmail={employee.Gmail}");
        }
        public static void Capitalize( Employee employee)
        {
            StringBuilder str=new StringBuilder();
            str.Append(Char.ToUpper(employee.Name[0]));

            for (int i = 1; i < employee.Name.Length; i++)
            {
                str.Append(Char.ToLower(employee.Name[i]));
            }
            employee.Name = str.ToString();
        }
        public static void CreateGmail( Employee employee)
        {
            employee.Gmail += "@gmail.com";
        }
    }
}