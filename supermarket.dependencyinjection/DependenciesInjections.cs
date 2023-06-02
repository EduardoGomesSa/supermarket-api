using Microsoft.Extensions.DependencyInjection;
using supermarket.application.Handlers;
using supermarket.application.Interfaces;
using supermarket.service.Interfaces;
using supermarket.service.services;

namespace supermarket.dependencyinjection
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductHandler, ProductHandler>();
            services.AddScoped<ICategoryHandler, CategoryHandler>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
