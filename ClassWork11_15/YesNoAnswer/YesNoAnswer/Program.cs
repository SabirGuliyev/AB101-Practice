#region YesNoApp

//1st version
//Console.WriteLine("silmek istediyinizden eminsiniz mi?");
//string answer = Console.ReadLine();
//do
//{
//    if (answer=="yes")
//    {
//        Console.WriteLine("Successfully deleted");
//    }
//    else if (answer == "no")
//    {
//        Console.WriteLine("Canceled");
//    }
//    else
//    {
//        Console.WriteLine("Bad request, try again:");
//        answer = Console.ReadLine();
//    }

//} while (answer!="yes"&&answer!="no");


//2nd version
//Console.WriteLine("daxil et");
//string answer = Console.ReadLine();

//while (answer != "yes" && answer != "no")
//{
//    Console.WriteLine("bad request try again:");
//    answer= Console.ReadLine();
//}

//if (answer=="yes")
//{
//    Console.WriteLine("success");

//}
//else
//{
//    Console.WriteLine("canceled");
//} 
#endregion


#region Operations on Digits
//1st version
//int num = 123;
//int counter = 0;

//if (num==0)
//{
//    counter++;
//}

//while (num!=0)
//{
//num /= 10;
//counter++;
//}


//2nd version

//int num = 123;
//int counter = 0;

//do
//{
//    num /= 10;
//    counter++;
//} while (num != 0);
//Console.WriteLine(counter);


//mertebelerin ekrana cixarilmasi
//int num = 123;
//int counter = 0;

//do
//{
//    Console.WriteLine(num%10);

//    num /= 10;
//    counter++;

//} while (num != 0);

//Console.WriteLine("count: "+counter); 
#endregion