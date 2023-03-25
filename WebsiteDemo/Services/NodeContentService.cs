using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace WebsiteDemo.Services
{
    public class NodeContentService
    {

        public string GetNodeContent(IPublishedContent node)
        {
            var data = new Dictionary<string, object>();


            data.Add("id", node.Id);
            data.Add("name", node.Name);
            data.Add("url", node.Url());


             var propList = node.Properties.Where(p => p.HasValue());
            foreach (IPublishedProperty prop in propList)
            {
                var propType = node.ContentType.GetPropertyType(prop.PropertyType.Alias);
                var propAlias = propType.EditorAlias;

                switch (propAlias)
                {
                 
                    case "Umbraco.NestedContent":
                    { 
                        IEnumerable<IPublishedElement> nodes = node.Value<IEnumerable<IPublishedElement>>(prop.PropertyType.Alias);
                        List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
                        foreach (var n in nodes)
                        {
                            Dictionary<string, object> dataItem = new Dictionary<string, object>();
                                dataItem.Add("id", n.Value("heading"));
                                dataItem.Add("name", n.Value("description"));
                                list.Add(dataItem);
                        }
                        data.Add(prop.PropertyType.Alias, list);
                    }
                    break;

             
                    case "Umbraco.TextBox":
                        {
                            data.Add(prop.PropertyType.Alias, node.Value(prop.PropertyType.Alias));
                        }
                        break;
                }
            }

            return JsonSerializer.Serialize(data);
        }

 
    }
}
