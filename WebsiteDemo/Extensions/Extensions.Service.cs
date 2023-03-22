using WebsiteDemo.Services;

namespace WebsiteDemo.Extensions
{
    public static partial class Extensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<MenuService>();
            services.AddScoped<PageService>();
        
        }
    }
}
