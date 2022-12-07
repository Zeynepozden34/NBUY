using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id); //ID'ye göre entity getirecek
        Task<List<T>> GetAllAsync(); //ilgili tüm kaytları liste ile getirecek
        Task CreateAsync(T entity); 
        void Update(T entity);
        void Delete(T entity);

    }
}
