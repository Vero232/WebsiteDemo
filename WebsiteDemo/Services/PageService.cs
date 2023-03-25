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
		private readonly NodeContentService _nodeContentService;

		public PageService(IUmbracoHelperAccessor umbracoHelperAccessor, IUmbracoMapper mapper, NodeContentService nodeContentService)
		{
			var sucess = umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
			if(!sucess)
			{
				return;
			}

			_umbracoHelper = umbracoHelper;

			_mapper = mapper;
			_nodeContentService = nodeContentService;
		}

		public Page GetPage(string url)
		{
			var page = _umbracoHelper.ContentAtRoot().Where(x => x.Url() == url).Select(x => new Page(x)).FirstOrDefault();
			var testPage = _umbracoHelper.ContentAtRoot().Where(x => x.Url() == url).FirstOrDefault();
			//testing GetNodeContent()
			var test = _nodeContentService.GetNodeContent(testPage);



			return page;
		}

	}
}
