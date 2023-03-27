using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Models
{
 
    public class Page
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Page(IPublishedContent content)
        {
            Url = content.Url();
            Title = content.Name();
            Id = content.Id;

        }
    }
    
}
