using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12_02.CustomExceptions
{
    internal class ReservedDateIntervalException:Exception
    {
        public ReservedDateIntervalException(string message):base(message)
        {
        }
    }
}
