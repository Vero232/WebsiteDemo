using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Interfaces
{
    public interface INodeContentService
    {
        string GetNodeContent(IPublishedContent node);
    }
}