﻿using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        void TransactionalOperation(Product p1,Product p2);
    }
}

