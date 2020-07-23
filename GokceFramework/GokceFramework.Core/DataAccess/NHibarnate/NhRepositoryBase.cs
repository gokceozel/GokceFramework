using GokceFramework.Core.Entities;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Core.DataAccess.NHibarnate
{
   public class NhRepositoryBase<TEntity>:IEntityRepository<TEntity> 
        where TEntity:class, IEntity ,new()
    {
        private NhibernateHelper _nhibernateHelper;
        public NhRepositoryBase(NhibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session=_nhibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using(var session = _nhibernateHelper.OpenSession())
            {
                session.Delete(entity);
               
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session=_nhibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using(var session = _nhibernateHelper.OpenSession())
            {
                return filter == null ? session.Query<TEntity>().ToList()
                                      : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
           using(var session = _nhibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
