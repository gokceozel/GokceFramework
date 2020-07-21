using System;
using GokceFramework.Norhwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GokceFramework.DataAccess.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Get_All_Products()
        {
            EfProductDal getAll = new EfProductDal();
            var result = getAll.GetList();
            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_All_Products_Category()
        {
            EfProductDal getAll = new EfProductDal();
            var result = getAll.GetListProductWithCategory();
            Assert.AreEqual(77, result.Count);
        }
    }
}
