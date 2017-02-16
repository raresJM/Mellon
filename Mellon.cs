using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mellon
{
    [TestClass]
    public class TestMellon
    {
        [TestMethod]
        public void TestIfEven_OnEvenNumber()
        {
            Assert.AreEqual(0,CheckIfEven(2));
        }

    }
}
