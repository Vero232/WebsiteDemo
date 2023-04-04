using System.Text.Json;
using Umbraco.Cms.Core.Models.PublishedContent;
using WebsiteDemo.Interfaces;
using WebsiteDemo.Models.ContentModels;

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

                void popDictionary<T>() 
                {
                    var fieldData = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);

                    content.Add(propType.ToFriendlyName(), _mappingService.MapContent<IEnumerable<IPublishedElement>, IEnumerable<T>>(fieldData));
                }

                void popDictionaryWithList<T>()
                {
                    var infoCardsList = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);

                    var formatedCards = infoCardsList.Select(infoCard => _mappingService.MapContent<IPublishedElement, T>(infoCard));

                    content.Add(propType.ToFriendlyName(), formatedCards);
                }

                switch (propType)
                {

                    case PropertyAlias.Introduction:
                         popDictionary<Introduction>();
                         break;
          
                    case PropertyAlias.HeroBanner:
                         popDictionaryWithList<HeroBanner>();
                         break;

                    case PropertyAlias.FAQ:
                         popDictionary<FAQ>();
                         break;

                   case PropertyAlias.InfoCards:
                        popDictionaryWithList<InfoCard>();
                        break;

                }
            }

            return JsonSerializer.Serialize(content.ToArray());
        }
    }
}
