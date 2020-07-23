using GokceFramework.Core.DataAccess.NHibarnate;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate
{
    public class NhCategoryDal : NhRepositoryBase<Category> ,ICategoryDal
    {
        public NhCategoryDal(NhibernateHelper nhibernateHelper) : base(nhibernateHelper)
        {
        }
    }
}
