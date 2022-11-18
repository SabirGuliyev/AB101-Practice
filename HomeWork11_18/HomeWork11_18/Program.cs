namespace HomeWork11_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array'in uzunlughunu daxil edin : ");
            int.TryParse(Console.ReadLine(), out int uzunluq);
            int[] array = new int[uzunluq];

            Console.WriteLine("array'in elementlerini daxil edin : ");
            for (int i = 0; i < uzunluq; i++)
            {
                int.TryParse(Console.ReadLine(), out int element);
                array[i] = element;
            }
            InsertArray(ref array, 12, 13, 14);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void InsertArray(ref int[] arr, params int[] nums)
        {
            int[] newArr = new int[arr.Length + nums.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            int num = 0;
            for (int i = arr.Length; i < newArr.Length; i++)
            {
                newArr[i] = nums[num];
                num++;
            }
            arr = newArr;
        }
    }
}