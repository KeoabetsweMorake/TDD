using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata1.Test
{
    class TestKata1
    {

        private RPS app;
        public TestKata1()
        {
            app = new RPS();
        }

        [TestCase("rock", "paper", "Player Losses")]
        [TestCase("rock", "rock", "Tie")]
        [TestCase("rock", "scissor", "Player Wins")]
        [TestCase("rock", "spock", "Player Losses")]
        [TestCase("paper", "rock", "Player Wins")]
        [TestCase("paper", "paper","Tie")]
        [TestCase("paper", "scissor","Player Losses")]
        [TestCase("paper", "spock","Player Wins")]
        [TestCase("scissor", "scissor", "Tie")]
        [TestCase("scissor", "paper","Player Wins")]
        [TestCase("scissor", "rock", "Player Losses")]
        [TestCase("scissor", "spock", "Player Losses")]
        [TestCase("spock", "scissor", "Player Wins")]
        [TestCase("spock", "paper", "Player Losses")]
        [TestCase("spock", "rock", "Player Wins")]
        public void playging(string m1, string m2, string res)
        {
            //arrange
            var x = app.play(m1, m2);
            //act
            //assert
            Assert.AreEqual(res, x);
        }
    }
}
