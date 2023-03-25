
using WebsiteDemo.Models;
using WebsiteDemo.Models.ContentModels;
using WebsiteDemo.Models.DTOs;
using WebsiteDemo.Services;

namespace WebsiteDemo.Extensions
{
    public static partial class Extensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<MenuService>();
            services.AddScoped<PageService>();
            services.AddScoped<NodeContentService>();
            services.AddScoped<MappingService<PageDTO>>();
            services.AddScoped<MappingService<TitleDTO>>();

        }
    }
}
