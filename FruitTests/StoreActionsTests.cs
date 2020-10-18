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

            StoreActions storeActions = new StoreActions();
            List<BaseFruit> list = new List<BaseFruit>();
            BasicStoreSet fruitsSet = new BasicStoreSet();
            var orangeSet = fruitsSet.Orange();
            var appleSet = fruitsSet.Apple();
            var bananaSet = fruitsSet.Banana();
            var cherrySet = fruitsSet.Cherry();
            list.Add(orangeSet);
            list.Add(appleSet);
            list.Add(bananaSet);
            list.Add(cherrySet);

            actual = storeActions.GetAllFruitsAmount(list);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetAllFruitsAmount_Fail_Test()
        {
            int actual;
            int expected = 399;

            StoreActions storeActions = new StoreActions();
            List<BaseFruit> list = new List<BaseFruit>();
            BasicStoreSet fruitsSet = new BasicStoreSet();
            var orangeSet = fruitsSet.Orange();
            var appleSet = fruitsSet.Apple();
            var bananaSet = fruitsSet.Banana();
            var cherrySet = fruitsSet.Cherry();
            list.Add(orangeSet);
            list.Add(appleSet);
            list.Add(bananaSet);
            list.Add(cherrySet);

            actual = storeActions.GetAllFruitsAmount(list);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetFruitsNamesList_Test()
        {
            List<string> expected = new List<string>() { "apple", "banana", "cherry" };
            List<string> actual;

            StoreActions storeActions = new StoreActions();
            List<BaseFruit> list = new List<BaseFruit>();
            
            BasicStoreSet fruitsSet = new BasicStoreSet();
            var a2 = fruitsSet.Apple();
            var appleSet = fruitsSet.Apple();
            var bananaSet = fruitsSet.Banana();
            var cherrySet = fruitsSet.Cherry();
            list.Add(a2);
            list.Add(appleSet);
            list.Add(bananaSet);
            list.Add(cherrySet);

            actual = storeActions.GetFruitsNamesList(list);
            actual.Sort();
            
            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetFruitsWeightNotGreater_Test()
        {
            List<string> expected = new List<string>() { "banana", "orange" };
            List<string> actual;

            StoreActions storeActions = new StoreActions();
            List<BaseFruit> list = new List<BaseFruit>();

            BasicStoreSet fruitsSet = new BasicStoreSet();
            var orangeSet = fruitsSet.Orange();
            var appleSet = fruitsSet.Apple();
            var bananaSet = fruitsSet.Banana();
            var cherrySet = fruitsSet.Cherry();
            list.Add(orangeSet);
            list.Add(appleSet);
            list.Add(bananaSet);
            list.Add(cherrySet);

            actual = storeActions.GetFruitsWeightNotGreater(list, 10);
            actual.Sort();

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [ExpectedException(typeof(NotImplementedException), "Exception was not thrown")]
        [TestMethod]
        public void GetAllFruitsAmount()
        {
            StoreActions storeActions = new StoreActions();
            storeActions.GetAllFruitsAmount(true);
        }

        [TestMethod]
        public void GetAllFruitColors_Test()
        {
            List<string> expected = new List<string>() { "green", "orange", "red", "yellow" };
            List<string> actual;

            StoreActions storeActions = new StoreActions();
            List<BaseFruit> list = new List<BaseFruit>();

            BasicStoreSet fruitsSet = new BasicStoreSet();
            var orangeSet = fruitsSet.Orange();
            var appleSet = fruitsSet.Apple();
            var bananaSet = fruitsSet.Banana();
            var cherrySet = fruitsSet.Cherry();
            list.Add(orangeSet);
            list.Add(appleSet);
            list.Add(bananaSet);
            list.Add(cherrySet);

            actual = storeActions.GetAllFruitColors(list);
            actual.Sort();

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }
    }

    

}
