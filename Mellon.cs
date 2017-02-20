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
        public void TestIfMellonCanBeSplitted_GoodScenario_01()
        {
            Assert.IsTrue(CheckIfCanBeSplitted(10));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_BadScenario_02()
        {
            Assert.IsFalse(CheckIfCanBeSplitted(9));
        }

        [TestMethod]
        public void TestIfMellonCanBeSplitted_BadScenario_03()
        {
            Assert.IsFalse(CheckIfCanBeSplitted(2));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_BadScenario_04()
        {
            Assert.IsFalse(CheckIfCanBeSplitted(3));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_SixKilos()
        {
            Assert.IsTrue(CheckIfCanBeSplitted(6));
        }
        [TestMethod]
        public void TestIfMellonCanBeSplitted_FourKilos()
        {
            Assert.IsTrue(CheckIfCanBeSplitted(4));
        }

        //The mellon can be splitted in two even number of kilos if 
        //kilos is an even number and also kilos is larger than or equal to 4!
        public bool CheckIfCanBeSplitted(int kilos)
        {
            bool result = false;
            if (CheckIfEven(kilos)) 
            {
                if (kilos >= 4) 
                {
                    result = true;
                }
            }

            return result;
        }

    }
}
