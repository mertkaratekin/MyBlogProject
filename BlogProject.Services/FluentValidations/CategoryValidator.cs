﻿using BlogProject.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.FluentValidations
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(a => a.Name).NotEmpty().NotNull().MinimumLength(3).MaximumLength(150).WithName("Kategori");
        }
    }
}
