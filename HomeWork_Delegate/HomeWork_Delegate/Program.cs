namespace HomeWork_Delegate
{
    internal class Program
    {
        //delegate bool Format(People people);
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            People person = new People("Ulviyya", "Naghizada", 17);
            People person3 = new People("Ulviyya", "Naghizada", 20);
            People person2 = new People("Shahnaz", "Mammadova", 19);
            people.Add(person);
            people.Add(person2);
            people.Add(person3);

            
           //List<People> people2 = people.FindAll(p => p.Name == "Ulviyya");

            foreach (People item in people.FindAll(p => p.Name == "Ulviyya" && p.Age>18))
            {
                Console.WriteLine(item.Name);
            }

            //foreach (People item in people)
            //{
            //    if (item.Name=="Ulviyya")
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}


            foreach (People item in people.FindAll((p) => p.Age >= 18))
            {
                Console.WriteLine(item.Age);
            }
            foreach (People item in people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova")))
            {
                Console.WriteLine(item.Surname);
            }

            //foreach (People item in people.FindAll(FindName))
            //{
            //    Console.WriteLine(item.Name);
            //}

        }

        //static bool FindSurname (People people)
        //{
        //    if(people.Surname.EndsWith("ov")|| people.Surname.EndsWith("ova"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //static bool FindAge(People people)
        //{
        //    if(people.Age> 18 /*people.Age>=18*/)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}