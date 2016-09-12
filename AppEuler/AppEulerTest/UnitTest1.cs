using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppEuler;


namespace AppEulerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSumMultiplesBelow()
        {
            Int64 answer = Program.SumMultiplesBelow(3, 5, 1000);

            Assert.AreEqual(233168, answer);

        }

        [TestMethod]
        public void TestMethodEvenFibonacciNumbers()
        {
            Int64 answer = Program.EvenFibonacciNumbers(4000000);

            Assert.AreEqual(4613732, answer);

        }

        [TestMethod]
        public void TestMethodSmallestMultiple()
        {
            Int64 answer = Program.SmallestMultiple(1, 20);

            Assert.AreEqual(232792560, answer);
            


        }
    }
}
