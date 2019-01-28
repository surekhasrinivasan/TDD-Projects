using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPasswordService;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Password pw = new Password();

        [Test]
        public void ThrowExceptionIfPasswordLengthIsLessThan6Chars()
        {
            var input = "alpha";
            Assert.Throws<System.ArgumentException>(() => pw.CheckPassword(input));
        }    
    }
}
