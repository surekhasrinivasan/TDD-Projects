using Fibonacci.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Tests
{
    // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

    [TestFixture]
    public class FibonacciSequenceTest
    {
        //[Test]
        //public void FibonacciSequence_FirstElement_IsOne()
        //{
        //    var seq = new FibonacciSequence();
        //    var result = seq.First();
        //    Assert.AreEqual(1, result);
        //}

        //[Test]
        //public void FibonacciSequence_SecondElement_IsOne()
        //{
        //    var seq = new FibonacciSequence();
        //    var result = seq.ElementAt(1);
        //    Assert.AreEqual(1, result);
        //}

        //[Test]
        //public void FibonacciSequence_ThirdElement_IsTwo()
        //{
        //    var seq = new FibonacciSequence();
        //    var result = seq.ElementAt(2);
        //    Assert.AreEqual(2, result);
        //}

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(6, 13)]
        [TestCase(7, 21)]
        [TestCase(8, 34)]
        [TestCase(9, 55)]
        [TestCase(10, 89)]
        [TestCase(11, 144)]
        public void FibonacciSequence_Element_IsValue(int n, int expected)
        {
            var seq = new FibonacciSequence();
            var result = seq.ElementAt(n);
            Assert.AreEqual(expected, result);
        }
    }
}
