using Umbraco.Cms.Core.Mapping;
using WebsiteDemo.Models;
using WebsiteDemo.Models.ContentModels;
using WebsiteDemo.Models.DTOs;

namespace WebsiteDemo.MappingDefinitions
{
    public class MapDefinition : IMapDefinition
    {
        public void DefineMaps(IUmbracoMapper mapper)
        {
            mapper.Define<Page, PageDTO>((source, context) => new PageDTO(), Map);
            mapper.Define<Title, TitleDTO>((source, context) => new TitleDTO(), MapTitle);
        }

        private void Map(Page source, PageDTO target, MapperContext context)
        {
            target.Title = source.Title;
            target.Url = source.Url;
        }
        private void MapTitle(Title source, TitleDTO target, MapperContext context)
        {
            target.TitleText = source.TitleText;

        }

    }
}
