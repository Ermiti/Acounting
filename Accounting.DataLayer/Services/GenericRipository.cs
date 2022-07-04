using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
      public  class GenericRipository<TEntity> where TEntity:class
      {
        private Accounting_DBEntities _db;
       private DbSet<TEntity> _dbSet;



        public GenericRipository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> Where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (query != null)
            {
                query = query.Where(Where);
            }
            return query.ToList();
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void UoDate(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State== EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(Object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
      }
}
