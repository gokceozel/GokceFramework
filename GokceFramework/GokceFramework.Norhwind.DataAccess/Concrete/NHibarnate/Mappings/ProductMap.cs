﻿using FluentNHibernate.Mapping;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProductId).Column("ProductID");
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");

        }
    }
}
