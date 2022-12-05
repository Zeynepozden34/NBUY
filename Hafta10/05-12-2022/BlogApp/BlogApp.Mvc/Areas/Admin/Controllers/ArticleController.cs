using BlogApp.Data.Abstract;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _articleService.GetAll();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        //public IActionResult Add()
        //{
        //    return PartialView("_ArticleAddPartial");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(ArticleAddDto articleAddDto) 
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _articleService.Add(articleAddDto, "Zeynep Özden");
        //        if (result.ResultStatus==ResultStatus.Success)
        //        {
        //            var articleAddAjaxModel = JsonSerializer.Serialize(new ArticleAddAjazModel
        //            {
        //                articleDto=result.Data,

        //            });
        //        }
        //    }
        //}
    }
}
