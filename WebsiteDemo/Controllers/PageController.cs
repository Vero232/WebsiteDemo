using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteDemo.Models;
using WebsiteDemo.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.Controllers;

namespace MyWebsite.Controllers
{

	//~/Umbraco/Api/ControllerName/Method
	public class PageController : UmbracoApiController
	{
		private readonly PageService _pageService;

		public PageController(PageService pageService)
		{
			_pageService = pageService;
		}


		public Page GetContent(string url)
		{
			return _pageService.GetPage(url);
		}
	}
}
