using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.Abstract;
using BlogApp.Shared.Utilities.Result.Complex_Types;
using BlogApp.Shared.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Article = BlogApp.Entities.Concrete.Article;

namespace BlogApp.Services.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitofWork? _unitOfWork;

        public ArticleManager(IUnitofWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(ArticleAddDto articleAddDto, string cretedByName)
        {
            await _unitOfWork.Articles.AddAsync(new Article
            {
                Title=articleAddDto.Title,
                Content=articleAddDto.Content,
                Thumbnail=articleAddDto.Thumbnail,
                Date=articleAddDto.Date,
                SeoAuthor=articleAddDto.SeoAuthor,
                SeoDescription=articleAddDto.SeoDescription,
                SeoTags=articleAddDto.SeoTags,
                IsActive=articleAddDto.IsActive,
                CategoryId=articleAddDto.CategoryId,
                CreatedDate=DateTime.Now,
                CreatedByName=cretedByName,
                ModifiedDate=DateTime.Now,
                ModifiedByName=cretedByName,
                IsDeleted=false

            }).ContinueWith(t=>_unitOfWork.SaveAsync());
            //await _unitOfWork.SaveAsync();
            return new Result
                (ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başatıyla eklenmiştir.");
                
                
                
               
        }

        public Task<IResult> Delete(int ArticleId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, a => a.Category, a=>a.User);
            if (article!=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article=article,
                    ResultStatus= ResultStatus.Success

                }); 
            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Böyle bir makale bulunamadı.", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null,  a => a.Category, a => a.User);
            if (articles!=null)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a=>a.IsDeleted, a => a.Category, a => a.User);
            if (articles.Count>0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles= articles,
                    ResultStatus= ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => a.IsDeleted && a.IsActive, a => a.Category, a => a.User);
            if (articles.Count > 0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hiç makale bulunamadı", null);

        }

        public async Task<IResult> HardDelete(int ArticleId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
