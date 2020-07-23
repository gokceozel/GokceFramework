using System;

using GokceFramework.Norhwind.DataAccess.Concrete.EntityFramework;
using GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate;
using GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate.Helper;
using GokceFramework.Northwind.DataAccess.Concrete.NHibernate;
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
            var result = getAll.GetProductDetails();
            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Nh_Get_All_Products()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetList();
            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Nh_Get_All_Cats()
        {
            NhCategoryDal nhProductDal = new NhCategoryDal(new SqlServerHelper());
            var result = nhProductDal.GetList();
            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Nh_Get_All_Products_Category()
        {
            NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
            var result = nhProductDal.GetProductDetails();
            Assert.AreEqual(77, result.Count);
        }

        //[TestMethod]
        //public void Test()
        //{
        //    NhProductDal nhProductDal = new NhProductDal(new SqlServerHelper());
        //    var result = nhProductDal.Test();
        //    Assert.AreEqual(77, result.Count);
        //}
    }
}
