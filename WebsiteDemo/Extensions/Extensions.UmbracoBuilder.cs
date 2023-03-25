using Umbraco.Cms.Core.Mapping;
using WebsiteDemo.MappingDefinitions;
using static WebsiteDemo.Helpers.MappingComposer;

namespace WebsiteDemo.Extensions
{
    public partial class Extensions
    {
        public static void MappingDefinitions(this IUmbracoBuilder builder)
        {
            builder.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<MapDefinition>();
        }
    }
}
