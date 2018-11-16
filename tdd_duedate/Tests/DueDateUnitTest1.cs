using NUnit.Framework;
using PaymentDateCheck;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class BillShould
    {
        [Test]
        public void ifBussinessDay_ReturnDueDate()
        {
            var input = new DateTime(2018, 8, 6);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = input;
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void ifSaturday_ReturnMonday()
        {
            var input = new DateTime(2018, 8, 4);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 8, 6);
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void ifSunday_ReturnMonday()
        {
            var input = new DateTime(2018, 8, 5);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 8, 6);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void ifHoliday_ReturnNonHoliday()
        {
            var input = new DateTime(2018, 12, 25);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 12, 26);
            Assert.AreEqual(expected, output);            
        }

        [Test]
        public void ifHoliday_ReturnWeekday()
        {
            var input = new DateTime(2018, 7, 4);
            var mockHolidayService = new HolidayService();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = new DateTime(2018, 7, 5);
            Assert.AreEqual(expected, output);            
        }
    }
}