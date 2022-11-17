namespace ClassWork11_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = { 1, 2, 3,4 };
            //Console.WriteLine(Search(ints, 5));
            char[] chars = { 'a', 'b' };
            chars = CustomResize(chars, 'c');

            foreach (char item in chars)
            {
                Console.WriteLine(item);
            }   
        }
        public static char[] CustomResize(char[] arr, char symbol)
        {
            char[] newArr = new char[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = symbol;

            return newArr;
        }
        //public static bool Search(int[] numbers, int num)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}
    }
   
}