using Microsoft.Extensions.DependencyInjection;
using BlogProject.Services.Services.Abstracts;
using BlogProject.Services.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using System.Globalization;
using BlogProject.Services.FluentValidations;
using Microsoft.AspNetCore.Http;

namespace BlogProject.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>(); //Article Service
            services.AddScoped<ICategoryService, CategoryService>(); //Category Service

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //ClaimsPrincipal Kullaniciyi bulma servisi

            var assembly = Assembly.GetExecutingAssembly(); //AutoMapper Service
            services.AddAutoMapper(assembly); //AutoMapper Service

            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            });

            return services;
        }
    }
}
