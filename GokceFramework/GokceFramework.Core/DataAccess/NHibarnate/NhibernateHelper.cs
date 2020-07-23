﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Core.DataAccess.NHibarnate
{
    public abstract class NhibernateHelper : IDisposable
    {

        public static ISessionFactory _sessionFactory; 
        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }

        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
