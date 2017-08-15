using System;
using BowlingKataTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private BowlingKata game;


        [TestInitialize]
        public void SetUp()
        {

           game = new BowlingKata();

        }


        [TestMethod]
        public void AllZeros()
        {

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.AreEqual(0, game.GetScore());
        }


        [TestMethod]
        public void AllOnes()
        {

            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.AreEqual(20, game.GetScore());
        }


        [TestMethod]
        public void Spares()
        {

            game.Roll(4);
            game.Roll(6);
            game.Roll(2);

            Assert.AreEqual(14, game.GetScore());

        }

        [TestMethod]
        public void Strike()
        {

            game.Roll(10);
            game.Roll(6);
            game.Roll(2);

            Assert.AreEqual(26, game.GetScore());

        }
    }
}
