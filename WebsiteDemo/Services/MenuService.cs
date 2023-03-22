using WebsiteDemo.Models;
using Umbraco.Cms.Web.Common;

namespace WebsiteDemo.Services
{
	public class MenuService
	{
		private readonly UmbracoHelper _umbracoHelper;

		public MenuService(IUmbracoHelperAccessor umbracoHelperAccessor)
		{
			var sucess = umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
			if(!sucess)
			{
				return;
			}

			_umbracoHelper = umbracoHelper;
		}

		public IEnumerable<MenuItem> GetHeaderMenu()
		{
			var menu = _umbracoHelper.ContentAtRoot().Select(x => new MenuItem(x));

			return menu;
		}

	}
}
