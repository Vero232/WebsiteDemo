using WebsiteDemo.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;


namespace WebsiteDemo.Services
{
    public class PageService : IPageService
    {
        private readonly IUmbracoContext _umbracoContext;

        public PageService(IUmbracoContextAccessor umbracoContextAccessor)
        {
            var sucess = umbracoContextAccessor.TryGetUmbracoContext(out var umbracoContext);
            if (!sucess)
            {
                return;
            }

            _umbracoContext = umbracoContext;
        }

        public IPublishedContent GetPage(string url)
        {
            var page = _umbracoContext.Content.GetByRoute(url);

            return page;
        }
    }
}
