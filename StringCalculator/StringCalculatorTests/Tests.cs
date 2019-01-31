using NUnit.Framework;
using StringCalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IfInputIsEmptyStringReturnZero()
        {
            var input = "";
            var expected = 0;
            var actual = Calculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsOneNumberReturnThatNumber()
        {
            var input = "1";
            var expected = 1;
            var actual = Calculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsTwoNumbersReturnTheirSum()
        {
            var input = "1, 2";
            var expected = 3;
            var actual = Calculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsMoreThanTwoNumbersReturnTheirSum()
        {
            var input = "5, 5, 5, 5";
            var expected = 20;
            var actual = Calculator.Add(input);
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

    }
}
