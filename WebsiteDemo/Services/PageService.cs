using WebsiteDemo.Models;
using System.Text.Json;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using WebsiteDemo.Models.ContentModels;

namespace WebsiteDemo.Services
{
	public class PageService
	{
		private readonly UmbracoHelper _umbracoHelper;
		private readonly NodeContentService _nodeContentService;
		public PageService(IUmbracoHelperAccessor umbracoHelperAccessor, IUmbracoMapper mapper, NodeContentService nodeContentService)
		{
			var sucess = umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
			if(!sucess)
			{
				return;
			}

			_umbracoHelper = umbracoHelper;
			_nodeContentService = nodeContentService;
		}

		public Page GetPage(string url)
		{
			var page = _umbracoHelper.ContentAtRoot().Where(x => x.Url() == url).Select(x => new Page(x)).FirstOrDefault();
			var page1 = _umbracoHelper.ContentAtRoot().Where(x => x.Url() == url).FirstOrDefault();

			_nodeContentService.GetNodeContent(page1);

			return page;
		}

	}
}
