using GokceFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokceFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<TEntity> _entites;
        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> Table => this.Entities;
        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entites == null)
                    _entites = _context.Set<TEntity>();
                return _entites;
            }
        }
    }
}
