using WebsiteDemo.Models;
using Umbraco.Cms.Web.Common.Controllers;
using WebsiteDemo.Interfaces;

namespace WebsiteDemo.Controllers
{
	//~/Umbraco/Api/ControllerName/Method
	public class MenuController : UmbracoApiController
	{
		private readonly IMenuService _menuService;

		public MenuController(IMenuService menuService)
		{
			_menuService = menuService;
		}

		public IEnumerable<MenuItem> GetHeaderMenu()
		{ 
			return _menuService.GetHeaderMenu();
		}
	}
}
