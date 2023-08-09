﻿using BlogProject.Data.UnitOfWorks;
using BlogProject.Services.Services.Abstracts;
using BlogProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace BlogProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IArticleService _articleService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _articleService = articleService;
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            return View(await _articleService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending));
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            return View(await _articleService.SearchAsync(keyword, currentPage, pageSize, isAscending));
        }
        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var article = await _articleService.GetArticleWithCategoryNonDeletedAsync(id);

            return View(article);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}