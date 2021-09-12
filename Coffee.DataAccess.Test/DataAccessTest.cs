using NUnit.Framework;

namespace Coffee.DataAccess.Test
{
    [TestFixture]
    public class DataAccessTest
    {
        IDataAccess _dataAccess;
        [SetUp]
        public void Setup()
        {
            _dataAccess = new DataAccess();
        }

        [TestCase(3)] // Cappaccino 
        [TestCase(2)] // coffee
        [TestCase(1)] // latte
        public void Test_isMilkAvailable(int qty)
        {
            bool result= _dataAccess.isMIlkAvailable(qty);
            NUnit.Framework.Assert.AreEqual(true,result);
        }


        [TestCase(5)] // Cappaccino 
        [TestCase(2)] // coffee
        [TestCase(3)] // latte
        public void Test_IsBeanAvailable(int qty)
        {
            bool result = _dataAccess.isMIlkAvailable(qty);
            NUnit.Framework.Assert.AreEqual(true, result);
        }
         
    }
}
