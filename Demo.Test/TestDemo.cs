using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Test
{
    public class TestDemo
    {
        private HelloWorld app;
        public TestDemo()
        {
            app = new HelloWorld();
        }

        [TestCase()]
        public void foobar()
        {
            //arrange
            var x = "Rock";
            //act
            //assert
            Assert.AreEqual("", x);
        }

        [TestCase()]
        public void RockPaper()
        {
            //arrange
            var x = true;
            //act
            //assert
            Assert.AreEqual(false, x);
        }
    }
}
