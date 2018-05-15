using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ZeMShoppingCart.ExceptionManager;

namespace ZeMShoppingCart.Data
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        #region Properties

        protected readonly ShoppingCartDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        #endregion

        #region Constructor

        protected Repository(ShoppingCartDbContext context)
        {
            Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        #endregion

        #region PublicGenericMethods
        public TEntity Get(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            try
            {
                return Context.Set<TEntity>().Find(id);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);
                return null;
            }

        }

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            try
            {
                return Context.Set<TEntity>().ToList();
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);
                return null;
            }

        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return Context.Set<TEntity>().Where(predicate);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);
                return null;
            }

        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return Context.Set<TEntity>().SingleOrDefault(predicate);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);
                return null;
            }

        }

        public void Add(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Add(entity);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);

            }

        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                Context.Set<TEntity>().AddRange(entities);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile( exceptions);

            }

        }

        public void Remove(TEntity entity)
        {
            try
            {
                Context.Set<TEntity>().Remove(entity);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);

            }

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            try
            {
                Context.Set<TEntity>().RemoveRange(entities);
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile(exceptions);

            }

        }

        public void Update(TEntity entity)
        {
            //  DbSet.Attach(entity);
            try
            {
                Context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception exceptions)
            {
                DataBaseExceptions.WriteExceptionMessageToFile( exceptions);

            }

        }

        #endregion

    }

}
