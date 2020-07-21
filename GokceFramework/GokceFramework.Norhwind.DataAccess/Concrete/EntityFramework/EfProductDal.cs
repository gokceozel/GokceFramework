using GokceFramework.Core.DataAccess.EntityFramework;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Entities.ComplexTypes;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetListProductWithCategory()
        {

            using (NorthwindContext context = new NorthwindContext())
            {

                var result = (from product in context.Products
                              join category in context.Categories
                              on product.CategoryId equals category.CategoryId
                              select new ProductDetail
                              {
                                  ProductId = product.ProductId,
                                  ProductName = product.ProductName,
                                  CategoryId = category.CategoryId,
                                  CategoryName = category.CategoryName
                              }).ToList();
                return result;
            }
        }
    }
}
