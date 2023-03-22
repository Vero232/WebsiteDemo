using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace WebsiteDemo.Models
{
	public class MenuItem
	{
		public string Url { get; set; }
		public string Title { get; set; }

		public MenuItem(IPublishedContent content) 
		{
			Url = content.Url();
			Title = content.Name();
		}
	}
}
