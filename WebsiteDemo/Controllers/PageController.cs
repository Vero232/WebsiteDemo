using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteDemo.Models;
using WebsiteDemo.Services;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Composing;

namespace MyWebsite.Controllers
{

	//~/Umbraco/Api/ControllerName/Method
	public class PageController : UmbracoApiController
	{
	
		private readonly PageService _pageService;
		private readonly IUmbracoMapper _mapper;
		private readonly MappingService<PageDTO> _mappingService;

		public PageController(PageService pageService, IUmbracoMapper mapper, MappingService<PageDTO> mappingService)
		{
			_pageService = pageService;

			_mapper = mapper;

			_mappingService = mappingService;
		}


		public Page GetContent(string url)
		{

			var page = _pageService.GetPage(url);
			var mapped = _mappingService.MapContent<Page, PageDTO> (page);

			return _pageService.GetPage(url);
		}

	}
}
