using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2.Test
{
    class TestKata2
    {
        FizzBuzz app;
        public TestKata2()
        {
            app = new FizzBuzz();
        }
        [TestCase(1, "1")]
        //[TestCase(2, "2")]
        [TestCase(2, "Whiz")]
        //[TestCase(3, "Fizz")]
        [TestCase(3, "FizzWhiz")]
        [TestCase(4, "4")]
        //[TestCase(5, "Buzz")]
        [TestCase(5, "BuzzWhiz")]
        [TestCase(6, "Fizz")]
        [TestCase(9,"Fizz")]
        [TestCase(10,"Buzz")]
        [TestCase(15,"FizzBuzz")]
        [TestCase(20,"Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(75, "FizzBuzz")]
        [TestCase(2, "Whiz")]
        public void fbuzz(int num, string res)
        {
            //arrange
            var x = app.fb(num);
            //act
            //assert
            Assert.AreEqual(res, x);
        }
    }
}
