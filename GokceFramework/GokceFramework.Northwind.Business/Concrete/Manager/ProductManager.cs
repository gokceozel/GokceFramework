using GokceFramework.Core.Aspects.Postsharp.CacheAspects;
using GokceFramework.Core.Aspects.Postsharp.LogAspects;
using GokceFramework.Core.Aspects.Postsharp.TransactionAspects;
using GokceFramework.Core.Aspects.Postsharp.ValidationAspects;
using GokceFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using GokceFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
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
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {

            return _productDal.Add(product);
        }

       // [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product p1, Product p2)
        {
            _productDal.Add(p1);
            _productDal.Update(p2);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
