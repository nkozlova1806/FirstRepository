using System;
using Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FruitTests
{
    [TestClass]
    public class StoreActionsTests
    {
        [TestMethod]
        public void GetAllFruitsAmount_HappyPath_Test()
        {
            int actual;
            int expected = 398;

            StoreActions baseFruitAmount = new StoreActions();
            actual = baseFruitAmount.GetAllFruitsAmount(List<BaseFruit> fruitsList);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetAllFruitsAmount_Fail_Test()
        {
            List<int> fruitAmount = new List<int>();

            fruitAmount.Add(100);
            fruitAmount.Add(50);
            fruitAmount.Add(10);
            fruitAmount.Add(200);

            int actual;
            int expected;

            StoreActions baseFruitAmount = new StoreActions();
            actual = baseFruitAmount.GetAllFruitsAmount(List<int> fruitAmount);
            expected = baseFruitAmount.GetAllFruitsAmount(List<BaseFruit> fruitsList);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }
    }
}
