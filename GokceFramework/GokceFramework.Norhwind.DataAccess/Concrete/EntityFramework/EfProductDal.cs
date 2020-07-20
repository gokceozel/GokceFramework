using GokceFramework.Core.DataAccess.EntityFramework;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
    }
}
