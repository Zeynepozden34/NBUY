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
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted(); //sadece silimemiş kayıtları gösterecek.
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive(); //Silinmemiş ve aktif kayıtlar
        Task<IResult> Add(CategoryAddDto categoryAddDto, string cretedByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string cretedByName);
        Task<IResult> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId); // Veri tabaınında kalıcı silmeyi sağlayan metot
    }
}
