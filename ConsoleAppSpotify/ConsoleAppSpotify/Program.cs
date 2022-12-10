using ConsoleAppSpotify.Functions;
using ConsoleAppSpotify.Models;

namespace ConsoleAppSpotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Music music = new Music("Breed", "Nirvana", 300);
            //Music music1 = new Music("Breed", "Nirvana", 300);
            //Console.WriteLine(music1.Id);

            User user = new User("guliyev","12233");
            string test = "asa123._sf";
            test.CheckUsername();
            User.RegisterUser();
            User.LoginUser();
        }
    }
}