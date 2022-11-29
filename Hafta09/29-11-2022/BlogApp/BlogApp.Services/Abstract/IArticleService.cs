using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Shared.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Abstract
{
    public interface IArticleService
    {
        // GEt, GetAll, Add, Delete, Update, HardDelete(Gerçek veri tabaınından silmek için kullanıcaz.), GetAllByNonDeleted(silinmemiş olanlar), GetAllByNondEletedAndActive(Silinmemiş ve active olanlar için), GetAlByCategory(CategoryId)
        // string cretedByName bunu yazmamızın nedeni daha sistemi kurmadığımız için girilen kullanıcıyı görmek için.

        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(ArticleAddDto articleAddDto, string cretedByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName); //Update olduğu için elimizde şu an bir ıd var. ilgili idli kaydı update yap şeklinde çalışacak
         Task<IResult> Delete(int ArticleId);
        Task<IResult> HardDelete(int ArticleId);
    }
}
