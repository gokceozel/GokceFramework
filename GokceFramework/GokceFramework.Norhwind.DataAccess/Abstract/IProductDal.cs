﻿using GokceFramework.Core.DataAccess;
using GokceFramework.Northwind.Entities.ComplexTypes;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
   
        List<ProductDetail> GetProductDetails();
    }
}
