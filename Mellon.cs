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


        [TestMethod]
        public void TestIfMellonCanBeSplitted_GoodScenario()
        {
            Assert.IsTrue(CheckIfCanBeSplitted(8));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_BadScenario_01()
        {
            Assert.IsFalse(CheckIfCanBeSplitted(10));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_BadScenario_02()
        {
            Assert.IsFalse(CheckIfCanBeSplitted(9));
        }
        //The mellon can be splitted in two even number of kilos if 
        //kilos is an even number and also kilos/2 is an even number!
        public bool CheckIfCanBeSplitted(int kilos)
        {
            bool result = false;
            if (CheckIfEven(kilos)) 
            {
                if (CheckIfEven(kilos / 2)) 
                {
                    result = true;
                }
            }

            return result;
        }

    }
}
