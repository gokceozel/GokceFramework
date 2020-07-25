﻿using GokceFramework.Core.Aspects.Postsharp.ValidationAspects;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Business.Abstract;
using GokceFramework.Northwind.Business.ValidationRules.FluentValidation;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Business.Concrete.Manager
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Add(Product product)
        {

            return _productDal.Add(product);
        }

     
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
