using Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList(); 
            }
        }

        public TEntity TAdd(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity); 
                context.SaveChanges();
                return entity;
            }
        }

        public void TDelete(int id)
        {
            using (var context = new TContext())
            {

                var entity = context.Set<TEntity>().Where(mission => mission.Id == id).SingleOrDefault();
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges(); 
            }
        }

        public void TUpdate(int id, TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
              
            }
        }
    }
}
