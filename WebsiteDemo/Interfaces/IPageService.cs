using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Interfaces
{
    public interface IPageService
    {
        IPublishedContent GetPage(string url);
    }
}