﻿using BlogProject.Entity.DTOs.Categories;
using BlogProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Services.Abstracts
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoriesNonDeletedAsync();
        Task<List<CategoryDto>> GetAllCategoriesDeletedAsync();
        Task AddCategoryAsync(CategoryAddDto categoryAddDto);
        Task<Category> GetCategoryByIdAsync(Guid categoryId);
        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<string> DeleteSafeCategoryAsync(Guid categoryId);
        Task<string> DeleteUndoCategoryAsync(Guid categoryId);
        Task<List<CategoryDto>> GetAllCategoriesNonDeletedTake24Async();

    }
}
