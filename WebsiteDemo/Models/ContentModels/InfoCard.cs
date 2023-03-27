using Umbraco.Cms.Core.Models;

namespace WebsiteDemo.Models.ContentModels
{
    public class InfoCard
    {
        public string Heading { get; set; }
        public string Description { get; set; }
        public Link ButtonLink { get; set; }
        public string ButtonName => ButtonLink.Name;
        public string ButtonTarget => ButtonLink.Target;
        public string ButtonURL => ButtonLink.Url;
    }
}
