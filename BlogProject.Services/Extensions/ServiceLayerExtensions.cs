using Microsoft.Extensions.DependencyInjection;
using BlogProject.Services.Services.Abstracts;
using BlogProject.Services.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>(); //Article Service

            var assembly = Assembly.GetExecutingAssembly(); //AutoMapper Service
            services.AddAutoMapper(assembly); //AutoMapper Service
            return services;
        }
    }
}
