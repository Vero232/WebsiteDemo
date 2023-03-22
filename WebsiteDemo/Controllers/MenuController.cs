using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteDemo.Models;
using WebsiteDemo.Services;
using Umbraco.Cms.Web.Common.Controllers;

namespace WebsiteDemo.Controllers
{
	//~/Umbraco/Api/ControllerName/Method
	public class MenuController : UmbracoApiController
	{
		private readonly MenuService _menuService;

		public MenuController(MenuService menuService)
		{
			_menuService = menuService;
		}

		[HttpGet]
		public IEnumerable<MenuItem> GetHeaderMenu()
		{ 
			return _menuService.GetHeaderMenu();
		}
	}
}
