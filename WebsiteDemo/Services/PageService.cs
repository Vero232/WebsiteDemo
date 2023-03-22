using WebsiteDemo.Models;
using System.Text.Json;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace WebsiteDemo.Services
{
	public class PageService
	{
		private readonly UmbracoHelper _umbracoHelper;
		private readonly IUmbracoMapper _mapper;

		public PageService(IUmbracoHelperAccessor umbracoHelperAccessor, IUmbracoMapper mapper)
		{
			var sucess = umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
			if(!sucess)
			{
				return;
			}

			_umbracoHelper = umbracoHelper;

			_mapper = mapper;
		}

		public Page GetPage(string url)
		{
			var page = _umbracoHelper.ContentAtRoot().Where(x => x.Url() == url).Select(x => new Page(x)).FirstOrDefault();

			var nestedContent = _mapper.Map<NestedContent>(page.Title);
		
			

			return page;
		}

	}
}
