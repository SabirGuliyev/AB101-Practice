using HomeWork12_02.Models;

namespace HomeWork12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule(); 
            meetingSchedule.SetMeeting(new DateTime(2022, 10, 11), new DateTime(2022, 10, 21), "Shahnaz");
            meetingSchedule.SetMeeting(new DateTime(2022, 10, 10), new DateTime(2022, 10, 25), "Ulviyya");

        }
    }
}