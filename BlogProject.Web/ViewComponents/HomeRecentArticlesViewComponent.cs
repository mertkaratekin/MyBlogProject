using BlogProject.Services.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.ViewComponents
{
    public class HomeRecentArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;

        public HomeRecentArticlesViewComponent(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recentArticles = await _articleService.GetAllArticlesWithCategoryNonDeletedTake3Async();

            return View(recentArticles);
        }
    }
}
