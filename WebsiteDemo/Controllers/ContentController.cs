using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteDemo.Models;
using WebsiteDemo.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Composing;
using WebsiteDemo.Extensions;
using WebsiteDemo.Interfaces;

namespace MyWebsite.Controllers
{

	//~/Umbraco/Api/ControllerName/Method
	public class ContentController : UmbracoApiController
	{
	
		private readonly IPageService _pageService;

		private readonly INodeContentService _nodeContentService;

		public ContentController(IPageService pageService, INodeContentService nodeContentService)
		{
			_pageService = pageService;

			_nodeContentService = nodeContentService;
		}


		public string GetContent(string url)
		{

			var page = _pageService.GetPage(url);

			var getContent = _nodeContentService.GetNodeContent(page);

			return getContent;
		}

	}
}
