using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzz.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] exp = new string[15]{"1","2", "fizz", "4","buzz", "fizz", "7","8", "fizz", "buzz","11", "fizz", "13", "14","fizzbuzz" };

            string[] actual_1 = Program.FizzBuzz(15);

            CollectionAssert.AreEqual(exp, actual_1);
        }
    }
}
