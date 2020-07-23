using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GokceFramework.Core.DataAccess.NHibarnate;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Entities.ComplexTypes;
using GokceFramework.Northwind.Entities.Concrete;
using NHibernate.Linq;

namespace GokceFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhRepositoryBase<Product>, IProductDal
    {
        private NhibernateHelper _nHibernateHelper;
        public NhProductDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }



        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName
                             };

                return result.ToList();

            }
        }

     
    }
}



