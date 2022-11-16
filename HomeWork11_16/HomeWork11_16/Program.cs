
//1.Task
//en boyuk olani tapmaq
//int eded = Convert.ToInt32(Console.ReadLine());
//int mertebe = 0;
//int maks_mertebe = 0;
//while (eded != 0)
//{
//    mertebe = eded % 10;
//    if (mertebe > maks_mertebe)
//    {
//        maks_mertebe = mertebe;
//    }
//    eded = eded / 10;
//}
//Console.WriteLine(maks_mertebe);



//en kicik olani tapmaq
//int num = 122767978;

////int digit = num % 10;
////num/=10;

//int digit = 9;

//while (num!=0)
//{
//    if (digit>num%10)
//    {
//        digit = num % 10;
//    }
//    num /= 10;
//}
//Console.WriteLine(digit);


//2.Task
Console.WriteLine("Enter a month:");
string month = Console.ReadLine();
bool result = true;
int maxDay=0;
while (result)
{
    switch (month)
    {
        case "yanvar" or "mart" or "may":
            maxDay = 31;
            result = false;
            break;
        case "noyabr" or "aprel":
            maxDay = 30;
            result = false;
            break;
        case "fevral":
            maxDay = 28;
            result = false;
            break;
        default:
            Console.WriteLine("wrong month name try again please:");
            month = Console.ReadLine();
            break;
    }
}
Console.WriteLine("Enter the day of month");
int day = Convert.ToInt32(Console.ReadLine());

while (!result)
{
    if (day>0 &&day<=maxDay)
    {
        result = true;
    }
    else
    {
        Console.WriteLine("Wrong day try again");
        day = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine(month+" "+day+" successfully reserved");