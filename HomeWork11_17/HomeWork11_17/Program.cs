namespace HomeWork11_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Min(9,0,1,5,3);

            Console.WriteLine(Area(3,4,5));
        }
        static int Area(int radius)
        {
            int pi = 3;
            return pi* radius *radius;
        }
        static int Area(int width,int length)
        {
            int area = width * length;
            return area;
        }
        static int Area(int width, int length,int height)
        {
            int area =2*(width *height + height * length + length * width);
            return area ;
        }
        static double Area(int width, int length, int height,int radius)
        {
            int semiPerimeter = (width + length + height) / 2;
            int area = semiPerimeter * radius ;
            return area;
        }







        //static void  Min (params int[] numbers)
        //{
        //    int min = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[min] > numbers[i])
        //        {
        //            min= i;
        //        }
        //    }
        //    Console.WriteLine(numbers[min]);
        //}



    }
}