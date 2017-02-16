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
            Assert.IsTrue(CheckIfEven(2));
        }
        public bool CheckIfEven(int number) 
        {
            bool result = false;
            if ((number % 2) == 0) 
            {
                result = true;   
            }
            return result;
        }

    }
}
