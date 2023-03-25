using System.Runtime.Serialization;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace WebsiteDemo.Models
{
    [DataContract(Name = "page")]
    public class PageDTO
    {
        [DataMember(Name = "Url")]
        public string Url { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Id")]
        public int Id { get; set; }
    }
}
