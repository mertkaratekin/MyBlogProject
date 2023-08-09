﻿using BlogProject.Entity.DTOs.Articles;
using BlogProject.Entity.DTOs.Categories;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Services.Abstracts
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync();
        Task AddArticleAsync(ArticleAddDto articleAddDto);
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task<string> DeleteSafeArticleAsync(Guid articleId);
        Task<string> DeleteUndoArticleAsync(Guid articleId);
        Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false);
        Task<ArticleListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false);
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedTake3Async();

    }
}
