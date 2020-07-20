﻿using GokceFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
