using AutoMapper;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Resolvers
{
    public class Resolvers
    {
        public class HeadingResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {
                return source.Value<string>("heading");
            }
        }

        public class DescriptionResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {

                return source.Value<string>("description");
            }
        }

        public class ButtonUrlResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {
                return source.Value<Link>("buttonLink").Url;
            }
        }

        public class ButtonNameResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {

                return source.Value<Link>("buttonLink").Name;
            }
        }

        public class ButtonTargetResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {
                return source.Value<Link>("buttonLink").Target;
            }
        }

        public class ImageUrlResolver<T> : IValueResolver<IPublishedElement, T, string>
        {
            public string Resolve(IPublishedElement source, T destination, string destMember, ResolutionContext context)
            {
                return source.Value<MediaWithCrops>("heroImage").LocalCrops.Src;
            }
        }
    }
}
