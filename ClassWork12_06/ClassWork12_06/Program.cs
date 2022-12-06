namespace ClassWork12_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                Task.Delay(10000).Wait();
                Console.Clear();
                Console.WriteLine("Hello World");
            });
            Console.Write("Loading");
            int count = 0;

            while (!task.IsCompleted)
            {
                count++;
                if (count<=3)
                {
                    Thread.Sleep(200);
                    Console.Write(".");
                }
                else
                {
                    Console.Clear();
                    Console.Write("Loading");
                    count = 0;
                }
            }
            
        }
    }
}