using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit;
using Moq;
using NUnit.Framework;
using Coffee.Business;
using Coffee.Interface;

namespace Coffee.Business.Test
{
    [TestFixture]
    public class BusinessTestCases
    {
        IDrink _coffee;
        [SetUp]
        public void SetUP()
        {
            _coffee = new CoffeeFactory().GetDrink();
        }

        [Test]
        public void TestMakeDrinkCoffee()
        {
             _coffee.MakeDrink();
            NUnit.Framework.Assert.IsTrue(true);
        }
    }
}
