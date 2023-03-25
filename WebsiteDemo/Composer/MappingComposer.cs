using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Mapping;
using WebsiteDemo.Extensions;
using WebsiteDemo.Models;

namespace WebsiteDemo.Helpers
{
    public class MappingComposer
    {

        public class MapComposer : IComposer
        {
            public void Compose(IUmbracoBuilder builder)
            {
                builder.MappingDefinitions();
            }
        }

    }
}
