﻿using BlogProject.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.Title).NotEmpty().NotNull().MinimumLength(3).MaximumLength(150).WithName("Başlık");
            RuleFor(a => a.Content).NotEmpty().NotNull().MinimumLength(3).MaximumLength(150).WithName("İçerik");
        }
    }
}
