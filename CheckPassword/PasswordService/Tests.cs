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
        [Test]
        public void PasswordLengthShouldNotBeLessThan6Chars()
        {
            var input = "alpha";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Length of the Password string cannot be less than 6 characters");
        }


        [Test]
        public void PasswordLengthShouldNotBeMoreThan12Chars()
        {
            var input = "passwordalpha";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Length of the Password string cannot be more than 12 characters");
        }


        [Test]
        public void PasswordShouldHaveNoWhiteSpace()
        {
            var input = "alPhas ";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Password string cannot have white space");
        }

        [Test]
        public void PasswordShouldHave1UpperCaseChar()
        {
            var input = "zebras";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Password should contain one upper case character");
        }

        [Test]
        public void PasswordShouldHave1LowerCaseChar()
        {
            var input = "CACTUS";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Password should contain one lower case character");
        }

        [Test]
        public void PasswordShouldNotHaveTwoSimilarCharactersConsecutively()
        {
            var input = "Tomorrow";
            bool expected = false;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Password string cannot have two similar characters consecutively");
        }

        [Test]
        public void PasswordShouldHave1SpecialChar()
        {
            var input = "$Smithonian";
            bool expected = true;
            bool actual = Password.CheckPassword(input);
            bool test;

            if (expected.Equals(actual))
                test = true;
            else
                test = false;
            Assert.IsTrue(test, "Password Should have 1 Special character");            
        }
    }
}
