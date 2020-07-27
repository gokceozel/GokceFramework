using System;
using FluentValidation;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Business.Concrete.Manager;
using GokceFramework.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GokceFramework.Business.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void ProductValidationCheck()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product { 
            ProductName="",
            CategoryId=1,
            UnitPrice=20,
            QuantityPerUnit="50"
            });

        }
    }
}
