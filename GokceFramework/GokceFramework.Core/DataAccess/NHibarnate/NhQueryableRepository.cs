using GokceFramework.Core.Entities;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Core.DataAccess.NHibarnate
{
    public class NhQueryableRepository<TEntity> : IQueryableRepository<TEntity>
         where TEntity : class, IEntity, new()
    {
        private NhibernateHelper _nhibernateHelper;
        private IQueryable<TEntity> _entities;
        public NhQueryableRepository(NhibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper ;
        }
        public IQueryable<TEntity> Table => this.Entities;
        

        public virtual IQueryable<TEntity> Entities 
         { 
            get {
                if (_entities == null)
                    _entities = _nhibernateHelper.OpenSession().Query<TEntity>();
                return _entities;
            }
        }
    }
}
