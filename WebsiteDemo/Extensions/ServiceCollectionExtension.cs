
using AutoMapper;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using WebsiteDemo.Interfaces;
using WebsiteDemo.Models.ContentModels;
using WebsiteDemo.Services;
using static WebsiteDemo.Resolvers.Resolvers;

namespace WebsiteDemo.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IPageService, PageService>();
            services.AddScoped<INodeContentService, NodeContentService>();
            services.AddScoped<IMappingService, MappingService>();

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x =>
            {
                x.CreateMissingTypeMaps = true;

                x.CreateMap<IPublishedElement, InfoCard>()
                    .ForMember(x => x.ButtonURL, opt => opt.MapFrom<ButtonUrlResolver<InfoCard>>())
                    .ForMember(x => x.ButtonName, opt => opt.MapFrom<ButtonNameResolver<InfoCard>>())
                    .ForMember(x => x.ButtonTarget, opt => opt.MapFrom<ButtonTargetResolver<InfoCard>>())
                    .ForMember(x => x.Heading, opt => opt.MapFrom<HeadingResolver<InfoCard>>())
                    .ForMember(x => x.Description, opt => opt.MapFrom<DescriptionResolver<InfoCard>>());

                x.CreateMap<IPublishedElement, HeroBanner>()
                   .ForMember(x => x.ButtonURL, opt => opt.MapFrom<ButtonUrlResolver<HeroBanner>>())
                   .ForMember(x => x.ButtonName, opt => opt.MapFrom<ButtonNameResolver<HeroBanner>>())
                   .ForMember(x => x.ButtonTarget, opt => opt.MapFrom<ButtonTargetResolver<HeroBanner>>())
                   .ForMember(x => x.HeroImageUrl, opt => opt.MapFrom<ImageUrlResolver<HeroBanner>>())
                   .ForMember(x => x.Heading, opt => opt.MapFrom<HeadingResolver<HeroBanner>>())
                   .ForMember(x => x.Description, opt => opt.MapFrom<DescriptionResolver<HeroBanner>>());
            });

            return services;
        }
    }
}
