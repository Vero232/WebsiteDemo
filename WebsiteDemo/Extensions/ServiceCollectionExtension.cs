
using WebsiteDemo.Interfaces;
using WebsiteDemo.Services;

namespace WebsiteDemo.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMenuService,MenuService>();
            services.AddScoped<IPageService, PageService>();
            services.AddScoped<INodeContentService, NodeContentService>();
            services.AddScoped<IMappingService, MappingService>();

            return services;
        }
    }
}
