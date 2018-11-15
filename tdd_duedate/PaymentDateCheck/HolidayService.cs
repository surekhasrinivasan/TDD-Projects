using System;
using System.Collections.Generic;

namespace PaymentDateCheck
{
    public class HolidayService : IHolidayService
    {
        public bool isHoliday(DateTime dueDate)
        {
            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(2018, 12, 25));
            holidays.Add(new DateTime(2018, 8, 3));
            if (holidays.Contains(dueDate))
                return true;

            return false;
        }
    }
}