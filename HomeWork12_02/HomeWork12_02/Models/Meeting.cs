using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12_02.Models
{
    internal class Meeting
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FullName { get; set; }

        public Meeting(DateTime fromDate, DateTime toDate, string fullName)
        {
            FromDate = fromDate;
            ToDate = toDate;
            FullName = fullName;
        }
    }
}
