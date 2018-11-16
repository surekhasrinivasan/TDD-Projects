using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        //use dependency injection

        IHolidayService holidayService;

        public Bill(IHolidayService holidayService)
        {
            this.holidayService = holidayService;
        }
        
        public DateTime CheckDate(DateTime dueDate)
        {
            DateTime paymentDate = dueDate;

            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
            {
                paymentDate = paymentDate.AddDays(2);
            }
            if (dueDate.DayOfWeek == DayOfWeek.Sunday)
            {
                paymentDate = paymentDate.AddDays(1);
            }
            if (holidayService.isHoliday(dueDate))
            {
                paymentDate = paymentDate.AddDays(1);
            }
            return paymentDate;
        }
    }

}

