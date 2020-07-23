using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GokceFramework.Core.DataAccess.NHibarnate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Norhwind.DataAccess.Concrete.NHibarnate.Helper
{
    public class SqlServerHelper : NhibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                 .ConnectionString(c => c.FromConnectionStringWithKey("NorthwindContext")))
             .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
             .BuildSessionFactory();
        }
    }
}
