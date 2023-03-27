using Umbraco.Cms.Core.Models;

namespace WebsiteDemo.Models.ContentModels
{
    public class HeroBanner
    {
        public MediaWithCrops HeroImage { get; set;}
        public string HeroImageUrl => HeroImage.LocalCrops.Src;
        public string Heading { get; set; }
        public string Description { get; set; }
        public Link ButtonLink { get; set; }
        public string ButtonName => ButtonLink.Name;
        public string ButtonTarget => ButtonLink.Url;
        public string ButtonURL => ButtonLink.Target;
    }
}
