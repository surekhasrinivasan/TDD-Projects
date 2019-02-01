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
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsOneNumberReturnThatNumber()
        {
            var input = "1";
            var expected = 1;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsTwoNumbersReturnTheirSum()
        {
            var input = "1, 2";
            var expected = 3;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputIsMoreThanTwoNumbersReturnTheirSum()
        {
            var input = "5, 5, 5, 5";
            var expected = 20;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputHasNewLinesBetweenNumbersReturnTheirSum()
        {
            var input = "10\n2,30\n";
            var expected = 42;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputHasDifferentDelimitersReturnTheSum()
        {
            var input = "//;\n1;2";
            var expected = 3;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThrowExceptionIfInputHasNegativeNumbers()
        {
            var input = "-1, 2, 3";
            Assert.Throws<System.ArgumentException>(() => Calculator.Add(input), "Negatives not allowed");
        }

        [Test]
        public void IfInputNumbersIsBiggerThan1000IgnoreReturnTheSumOfOtherNumbers()
        {
            var input = "1, 2, 1001";
            var expected = 3;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputDelimitersCanBeAnyLengthReturnTheNumbersSum()
        {
            var input = "//[***]\n1***2***3";
            var expected = 6;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputAllowMultipleDelimitersReturnTheNumbersSum()
        {
            var input = "//[*][%]\n11*2%3";
            var expected = 16;
            var actual = Calculator.Add(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
