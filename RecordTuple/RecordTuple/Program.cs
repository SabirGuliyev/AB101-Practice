namespace RecordTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Record init
            PersonClass person = new PersonClass("Sabir", "Guliyev");
            PersonClass person2 = new PersonClass("Sabir", "Guliyev");
            Console.WriteLine(person.FullName);


            //PersonRecord personRecord = new PersonRecord("Samir", "Guliyev");
            //personRecord.Name = "Abbasov";
            //PersonRecord personRecord2 = new PersonRecord("Sabir", "Guliyev");
            //StudentRecord student = new StudentRecord("Terlan", "Heydarov","AB101");

            //Console.WriteLine(person);

            //Console.WriteLine(personRecord);
            //Console.WriteLine(student); 

            //personRecord = personRecord with
            //{
            //    Name="Kamil"
            //},
            #endregion

            #region Tuple

            //Tuple
            //string month = "Yanvar";
            //int day = 31;

            //object month = new
            //{
            //    Name = "Yanvar",
            //    Day = 31
            //};

            ((int, int), string Name) month = ((31, 30), "Yanvar");
            Console.WriteLine(month);

            //month.Item2 = "Oktyabr";
            //month.Day = 21;
            //month.Item2 = "Fevral";
            //Console.WriteLine(month);

            //var month = Tuple.Create(31, "Yanvar");
            //Console.WriteLine(month);
            //int[] numbers = { 7, 4, 8, 1, 6, 4 };


            //var result=FindMinMax(numbers);
            (string, int) answers = (Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(answers);
            //Console.WriteLine("Min deyer: "+result.Min);
            //Console.WriteLine(result); 
            #endregion
        }
        public static (int Min,int Max) FindMinMax(int[] arr)
        {
            Array.Sort(arr);

            return (arr[0], arr[arr.Length - 1]);
        }
    }
}