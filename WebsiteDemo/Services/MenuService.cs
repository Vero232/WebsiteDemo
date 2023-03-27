using WebsiteDemo.Models;
using Umbraco.Cms.Web.Common;
using WebsiteDemo.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Services
{
    public class MenuService : IMenuService
    {
        private const string _headerMenuAlias = "menuItems";
        private const string _contentNodeAlias = "website";

        private readonly UmbracoHelper _umbracoHelper;

        public MenuService(IUmbracoHelperAccessor umbracoHelperAccessor)
        {
            var success = umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
            if (!success)
            {
                return;
            }

            _umbracoHelper = umbracoHelper;
        }

        public IEnumerable<MenuItem> GetHeaderMenu()
        {
            var rootNode = _umbracoHelper.ContentAtRoot().FirstOrDefault(x => x.ContentType.Alias == _contentNodeAlias);

            return rootNode.Value<IEnumerable<IPublishedContent>>(_headerMenuAlias).Select(x => new MenuItem(x));
        }

    }
}
