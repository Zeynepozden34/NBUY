using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] IncludeProperties); //Not-1, Not-2 

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] IncludeProperties); //Not-3

        Task AddAsync(T entity); 
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);



    }

}


/*
 * Not-1
 * *********
 * Örneğin Id=12 olan Article kaydı getir
 * var article =repository.GetAsync(x=>x.Id==12);
 * User user =repositoryUser.GetAsync(x=>x.Name=="Zeynepozden")
 * 
 * Not-2
 * **********
 * Örneğin Id=12 olan Article'ı user ve commentleriyle getirmek isityoruz
 * Article article = repositoryArticle.GetAsyn(x=>x.Id==12, y=>y.User, y=>y.Comments, z=>z.Role)
 * 
 * Not-3
 * **********
 * Tüm articeleri listelemek için
 * var articles=repositoryArticle.GetAllAsync() 
 * Örneğin dotnet categorisindeki tüm articleri listelmek için
 * var articles=repositoryArticle.GetAllAsync(a=>a.Category.Name=="Dotnet", c=>c.Category)
 * Örenğin Id'si 12 olan Article yorumlarını getirelim
 * var comments=repositoryComment.GetAllAsynv(c=>c.ArticleId==12)
 * 
 */

//Task<T> GetAsync(Expression<Func<T, bool>> predicate); bu istenilen entiyde istenilen şekilde arama yapar. yazar adı yada başlığa göre aramasını sağlayack.
//params birinci filtrelemeden(pridicateye kadar)sonra ne yazarsak yazarım object filtresine yazabiliriz.
//Task AddAsync(T entity); geri döndürülen değer kullamayacam void yazmama da gerek yok böyle kullanılıyor.