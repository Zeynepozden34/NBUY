using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Data.Concrete.EntityFrameWork;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity) 
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] IncludeProperties)
        {
         
            IQueryable<TEntity>query=_context.Set<TEntity>();
            if (predicate!=null)
            {
                query=query.Where(predicate);
            }
            if (IncludeProperties.Any()) 
            {
                foreach (var includeProperty in IncludeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.ToListAsync();
        }
     
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] IncludeProperties)
        {
            IQueryable<TEntity> query=_context.Set<TEntity>();
            query=query.Where(predicate);
            if (IncludeProperties.Any())
            {
                foreach (var includeProperty in IncludeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync();
            //return await query.SingleOrDefaultAsync();
        }


    }
}

/* private readonly DbContext _context;  sadece  EfEntityRepositoryBase(DbContext context) bu kullanabilecek VE dğiştirlemeyecek. proje07 constract metoduna bakabilriisn.
public EfEntityRepositoryBase(DbContext context)
{
    _context = context;
}
*/

// await asenc metot çağırmak için kulanılır 
//Task<bool> RETURN KULLANILMALI

// remove ve update ascnc olmaz bu nedenle aşağıda asencron yaptık.  await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });

//where TEntity : class, IEntity, new() en başta yazılanlar T nin kısıtlarıdır bir sınıf olmalı entity olmalı yeni birşey ekleyebilirz.

//IQUAREBLE ARAŞTIR.

// if (IncludeProperties.Any()) IncludeProperties içinde birşey varsa çalışır.

//FirstOrDefaultAsync() tek kaydı döndürecceksekse kullanırız bütün aynı adları döndürür ama karşılaştığı ilk kaydı getirir. single ise sadece o kaydı döndürür ve o kaydı getirir
//Blog sopt