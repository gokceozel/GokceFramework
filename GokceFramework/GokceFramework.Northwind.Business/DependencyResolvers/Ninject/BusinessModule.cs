using GokceFramework.Core.DataAccess;
using GokceFramework.Core.DataAccess.EntityFramework;
using GokceFramework.Core.DataAccess.NHibarnate;
using GokceFramework.Norhwind.DataAccess;
using GokceFramework.Norhwind.DataAccess.Abstract;
using GokceFramework.Norhwind.DataAccess.Concrete.EntityFramework;
using GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate.Helper;
using GokceFramework.Northwind.Business.Abstract;
using GokceFramework.Northwind.Business.Concrete.Manager;
using GokceFramework.Northwind.Entities.Concrete;
using Ninject.Modules;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();
            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();

            #region Nhibernate
            Bind<NhibernateHelper>().To<SqlServerHelper>();
            #endregion
        }
    }
}
