using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using WebsiteDemo.Models.ContentModels;
using WebsiteDemo.Models.DTOs;

namespace WebsiteDemo.Services
{
    public class NodeContentService
    {
        private readonly MappingService<TitleDTO> _mappingService;

        public NodeContentService( MappingService<TitleDTO> mappingService)
        {
            _mappingService = mappingService;
        }

        public string GetNodeContent(IPublishedContent node)
        {
            var data = new Dictionary<string, object>();

            var propList = node.Properties.Where(p => p.HasValue());

            Title titleText = new Title { TitleText = node.Value("titleText").ToString() };

            var mapped = _mappingService.MapContent<Title, TitleDTO>(titleText);

            //foreach (IPublishedProperty prop in propList)
            //{
            //    //var propType = node.ContentType.GetPropertyType(prop.PropertyType.Alias);

            //}

            return JsonSerializer.Serialize(data);
        }

 
    }
}
