using System;
using Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;

namespace FruitTests
{
    [TestClass]
    public class BaseFruitTests
    {
        [TestMethod]
        public void GetFruitsPriceByWeight_WeightAndPrice()
        {
            double expected = 22.5;
            double actual;

            BaseFruit baseFruitWeight = new BaseFruit(4.5, 100, "carrot", "orange", 5);
            actual = baseFruitWeight.GetFruitsPriceByWeight();

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception was not thrown")]
        [TestMethod]
        public void GetFruitsPriceByWeight_WeightAndPrice_LessThanZeroPrice()
        {
            BaseFruit baseFruitWeight = new BaseFruit(4.5, 100, "carrot", "orange", -5);
            baseFruitWeight.GetFruitsPriceByWeight();
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception was not thrown")]
        [TestMethod]
        public void GetFruitsPriceByWeight_WeightAndPrice_LessThanZeroWeight()
        {
            BaseFruit baseFruitWeight = new BaseFruit(-4.5, 100, "carrot", "orange", 5);
            baseFruitWeight.GetFruitsPriceByWeight();
        }

        [TestMethod]
        public void GetFruitsPriceByAmount_AmountAndPrice()
        {
            double expected = 500;
            double actual;

            BaseFruit baseFruitAmount = new BaseFruit(4.5, 100, "carrot", "orange", 5);
            actual = baseFruitAmount.GetFruitsPriceByAmount();

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetFruitsTaxedPriceByAmount_PriceWithTaxAndAmount()
        {
            double expected = 550;
            double actual;

            BaseFruit baseFruitAmount = new BaseFruit(4.5, 100, "carrot", "orange", 5);
            actual = baseFruitAmount.GetFruitsTaxedPriceByAmount(5.5);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        [TestMethod]
        public void GetTotalWeight_AmountAndWeight()
        {
            double expected = 450;
            double actual;

            BaseFruit baseFruitAmount = new BaseFruit(4.5, 100, "carrot", "orange", 5);
            actual = baseFruitAmount.GetTotalWeight();

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }

        //[TestMethod]
        public void GetPriceWithTax_PriceAndTax()
        {
            double expected = 5.5;
            double actual;

            BaseFruit baseFruitAmount = new BaseFruit(4.5, 100, "carrot", "orange", 5);
            actual = baseFruitAmount.GetPriceWithTax(0.1);

            NUnit.Framework.Assert.AreEqual(expected, actual, $"Expected result is {0}, but actual result was {1}");
        }
    }
}
