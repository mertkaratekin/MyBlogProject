﻿using BlogProject.Services.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class DefaultController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IDashboardService _dashboardService;

        public DefaultController(IArticleService articleService, IDashboardService dashboardService)
        {
            _articleService = articleService;
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _articleService.GetAllArticlesWithCategoryNonDeletedAsync());
        }

        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await _dashboardService.GetYearlyArticleCountsAsync();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await _dashboardService.TotalCategoryCountAsync();
            return Json(count);
            //return Json(JsonConvert.SerializeObject(count));
        }

        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await _dashboardService.TotalArticleCountAsync();
            return Json(count);
            //return Json(JsonConvert.SerializeObject(count));
        }
    }
}
