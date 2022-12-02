using HomeWork12_02.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12_02.Models
{
    internal class MeetingSchedule
    {
        public Meeting[] Meetings;

        public MeetingSchedule()
        {
            Meetings = new Meeting[0];
        }

        public void SetMeeting(DateTime fromDate,DateTime toDate,string fullName)
        {
            try
            {
                if (fromDate >= toDate)
                {
                    throw new WrongDateIntervalException("Wrong Date Interval");
                }
                for (int i = 0; i < Meetings.Length; i++)
                {
                    if (Meetings[i].FromDate < fromDate && Meetings[i].ToDate > toDate
                        || Meetings[i].FromDate > fromDate && Meetings[i].ToDate > toDate
                        || Meetings[i].FromDate > fromDate && Meetings[i].ToDate < toDate
                        || Meetings[i].FromDate < fromDate && Meetings[i].ToDate > fromDate)
                    {
                        throw new ReservedDateIntervalException("Reserved Date Interval");
                    }
                }
                Meeting meetings = new Meeting(fromDate, toDate, fullName);

                Array.Resize(ref Meetings, Meetings.Length + 1);
                Meetings[Meetings.Length - 1] = meetings;
            }
            catch (Exception ex)
            {
                //throw ex;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
