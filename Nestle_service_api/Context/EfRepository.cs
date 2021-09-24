using Microsoft.EntityFrameworkCore;
using Nestle_service_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nestle_service_api.Context
{
    public class EfRepository<T> : IEfRepository<T> where T : BaseEntity
    {
        protected Nestle_Connect context;

        public IQueryable<T> Table { get => context.Set<T>().AsQueryable(); }

        public EfRepository(Nestle_Connect dbContext)
        {
            context = dbContext;
        }
        public async Task<bool> AddRangeAsync(List<T> entity)
        {
            context.Set<T>().AddRange(entity);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> AddAsync(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<T> FindByIdAsync(object id) => await context.Set<T>().FindAsync(id);
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => await context.Set<T>().FirstOrDefaultAsync(predicate);
        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate) => context.Set<T>().Where(predicate).AsEnumerable();

    }
}
