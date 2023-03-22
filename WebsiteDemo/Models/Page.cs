using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace WebsiteDemo.Models
{
	public class Page
	{
		public string Url { get; set; }
		public string Title { get; set; }
		public int Id { get; set; }
		public object NestedContent { get; set; }

		public Page(IPublishedContent content) 
		{
			Url = content.Url();
			Title = content.Name();
			Id = content.Id;
			NestedContent =  content.Value("content");
		}
	}
}
