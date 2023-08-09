﻿using BlogProject.Data.UnitOfWorks;
using BlogProject.Entity.Entities;
using BlogProject.Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Services.Concretes
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<int>> GetYearlyArticleCountsAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted);

            var startDate = DateTime.Now.Date;
            startDate = new DateTime(startDate.Year, 1, 1);

            List<int> datas = new();

            for (int i = 1; i <= 12; i++)
            {
                var startedDate = new DateTime(startDate.Year, i, 1);
                var endedDate = startedDate.AddMonths(1);
                var data = articles.Where(x => x.CreatedDate >= startedDate && x.CreatedDate < endedDate).Count();
                datas.Add(data);
            }

            return datas;
        }
        public async Task<int> TotalCategoryCountAsync()
        {
            var totalCategoryCount = await _unitOfWork.GetRepository<Category>().CountAsync();
            return totalCategoryCount;
        }

        public async Task<int> TotalArticleCountAsync()
        {
            var totalArticleCount = await _unitOfWork.GetRepository<Article>().CountAsync();
            return totalArticleCount;
        }
    }
}
