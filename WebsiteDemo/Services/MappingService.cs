using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using WebsiteDemo.Models;

namespace WebsiteDemo.Services
{
    public class MappingService<T> where T : class
    {
        private readonly IUmbracoMapper _umbracoMapper;

        public MappingService(IUmbracoMapper umbracoMapper)
        {

            _umbracoMapper = umbracoMapper;
        }
        public TReturn MapContent<T, TReturn>(T content)
        {

           var mappedContent = _umbracoMapper.Map<T, TReturn>(content);

            return mappedContent;
        }
    }
}
