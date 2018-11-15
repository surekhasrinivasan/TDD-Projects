using System;

namespace PaymentDateCheck
{
    public interface IHolidayService
    {
        bool isHoliday(DateTime duedate);
    }
}