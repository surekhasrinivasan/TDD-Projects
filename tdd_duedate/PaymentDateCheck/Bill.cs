using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        //use dependency injection

        IHolidayService holidayService;

        public Bill(IHolidayService hs)
        {
            this.holidayService = hs;
        }
        
        public DateTime CheckDate(DateTime dueDate)
        {
            if(dueDate.DayOfWeek == DayOfWeek.Saturday)
            {
               dueDate = dueDate.AddDays(2);
            }
            return dueDate;
        }
    }

}

