﻿using BlogProject.Entity.DTOs.Categories;
using BlogProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryDto> Categories { get; set; }
        public Guid AppUserId { get; set; } = Guid.Parse("2C34DA79-F839-4AA8-95DE-1D31A3B39C28");
        public AppUser AppUser { get; set; }
    }
}
