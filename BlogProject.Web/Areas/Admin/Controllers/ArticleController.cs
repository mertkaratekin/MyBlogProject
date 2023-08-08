using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using BlogProject.Entity.DTOs.Articles;
using BlogProject.Entity.DTOs.Categories;
using BlogProject.Entity.Entities;
using BlogProject.Services.Extensions;
using BlogProject.Services.Services.Abstracts;
using BlogProject.Core.Utils;
using NToastNotify;
using BlogProject.Core.Consts;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace BlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IValidator<Article> _validator;
        private readonly IToastNotification _toastNotification;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IValidator<Article> validator, IToastNotification toastNotification)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
            _validator = validator;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]

        public async Task<IActionResult> Index()
        {
            return View(await _articleService.GetAllArticlesWithCategoryNonDeletedAsync());
        }
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> DeletedArticle()
        {
            return View(await _articleService.GetAllArticlesWithCategoryDeletedAsync());
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> Add()
        {
            var categories = await _categoryService.GetAllCategoriesNonDeletedAsync();
            return View(new ArticleAddDto { Categories = categories });
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = _mapper.Map<Article>(articleAddDto);
            var result = await _validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await _articleService.AddArticleAsync(articleAddDto);
                _toastNotification.AddSuccessToastMessage(ToastrMessages.ArticleMessage.AddMessage(articleAddDto.Title), new ToastrOptions { Title = "Başarılı !" });
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
                List<CategoryDto> categories = await _categoryService.GetAllCategoriesNonDeletedAsync();
                return View(new ArticleAddDto { Categories = categories });
            }
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article = await _articleService.GetArticleWithCategoryNonDeletedAsync(articleId);

            var categories = await _categoryService.GetAllCategoriesNonDeletedAsync();

            ArticleUpdateDto articleUpdateDto = _mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = _mapper.Map<Article>(articleUpdateDto);
            var result = await _validator.ValidateAsync(map);

            if (result.IsValid)
            {
                string title = await _articleService.UpdateArticleAsync(articleUpdateDto);
                _toastNotification.AddInfoToastMessage(ToastrMessages.ArticleMessage.UpdateMessage(title), new ToastrOptions { Title = "Başarılı !" }); 
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await _categoryService.GetAllCategoriesNonDeletedAsync();
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> Delete(Guid articleId)
        {
            var title = await _articleService.DeleteSafeArticleAsync(articleId);
            _toastNotification.AddWarningToastMessage(ToastrMessages.ArticleMessage.DeleteMessage(title), new ToastrOptions { Title = "Başarılı !" });
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.SuperAdmin},{RoleConsts.Admin},{RoleConsts.Editor}")]
        public async Task<IActionResult> UndoDelete(Guid articleId)
        {
            var title = await _articleService.DeleteUndoArticleAsync(articleId);
            _toastNotification.AddWarningToastMessage(ToastrMessages.ArticleMessage.UndoDeleteMessage(title), new ToastrOptions { Title = "Başarılı !" });
            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
    }
}
