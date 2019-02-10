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
        [Test]
        public void FibonacciSequence_FirstElement_IsOne()
        {
            var seq = new FibonacciSequence();
            var result = seq.First();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FibonacciSequence_SecondElement_IsOne()
        {
            var seq = new FibonacciSequence();
            var result = seq.ElementAt(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FibonacciSequence_ThirdElement_IsTwo()
        {
            var seq = new FibonacciSequence();
            var result = seq.ElementAt(2);
            Assert.AreEqual(2, result);
        }
    }
}
