using System.Text.Json;
using Umbraco.Cms.Core.Models.PublishedContent;
using WebsiteDemo.Interfaces;
using WebsiteDemo.Models.ContentModels;
using WebsiteDemo.Models.DTO;

namespace WebsiteDemo.Services
{
    public class NodeContentService :  INodeContentService
    {

        private readonly IMappingService _mappingService;
 
        public NodeContentService(IMappingService mappingService)
        {
            _mappingService = mappingService;
 
        }
     
        public string GetNodeContent(IPublishedContent node)
        {
            var content = new Dictionary<string, object>();

            var propList = node.Properties.Where(p => p.HasValue());


            foreach (IPublishedProperty prop in propList)
            {
                var propType = prop.PropertyType.Alias;

                switch (propType)
                {

                    case "introduction":

                        var introduction = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);

                        content.Add(propType.ToFriendlyName(), _mappingService.MapContent<IEnumerable<IPublishedElement>, IEnumerable<Introduction>>(introduction));

                        break;
          
                    case "heroBanner":

                        var listHeroBanner = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);

                        var heroBanner = _mappingService.MapContent<IEnumerable<IPublishedElement>, IEnumerable<HeroBanner>>(listHeroBanner);

                        var formattedBanner = _mappingService.MapContent<IEnumerable<HeroBanner>, IEnumerable<HeroBannerDTO>>(heroBanner);

                        content.Add(propType.ToFriendlyName(), formattedBanner);

                        break;

                    case "frequentlyAskedQuestions":

                        var faqs = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);


                         content.Add(propType.ToFriendlyName(), _mappingService.MapContent<IEnumerable<IPublishedElement>, IEnumerable<FAQ>>(faqs));

                         break;

                   case "infoCards":

                        var infoCardsList = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);

                        var infoCards = _mappingService.MapContent<IEnumerable<IPublishedElement>, IEnumerable<InfoCard>>(infoCardsList);

                        var formatedCards = _mappingService.MapContent<IEnumerable<InfoCard>, IEnumerable<InfoCardDTO>>(infoCards);

                        content.Add(propType.ToFriendlyName(), formatedCards);

                        break;

                }

            }


            return JsonSerializer.Serialize(content.ToArray());
        }

    }
}
