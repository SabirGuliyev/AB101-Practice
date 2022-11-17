namespace ClassWork11_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calculate(4,0,'/'));
            //int num = Convert.ToInt32(Console.ReadLine());

            //int result=DefinePower(Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine(result);


            //Console.WriteLine(UpToPower(5));


            PrintConsole("Sabir");
            PrintConsole("sabir", "guliyev");
            PrintConsole("sabir", "guliyev","Mehti");

        }
        public static void PrintConsole(string name)
        {
            Console.WriteLine(name);
        }
        public static void PrintConsole(string name,string surname)
        {
            Console.WriteLine(surname+" "+name);
        }

        public static void PrintConsole(string surname,string name,string father)
        {
            Console.WriteLine(name[0]+"."+surname+" "+father);
        }

        //public static int UpToPower(int number,int power=2)
        //{
        //    int result = 1;

        //    for (int i = 0; i < power; i++)
        //    {
        //        result *= number;
        //    }

        //    return result;
        //} 

        //public static int DefinePower(int a)
        //{
        //    return a * a;
        //}
        //public static int Calculate(int a,int b, char symbol)
        //{
        //    int result=0;
        //    switch (symbol)
        //    {
        //        case '+':
        //            result = a + b;
        //            break;
        //        case '-':
        //            result = a - b;
        //            break;
        //        case '*':
        //            result = a * b;
        //            break;
        //        case '/':
        //            result = a / b;
        //            break;
        //        default:
        //            break;
        //    }
        //    return result;

        //}


       
    }
}