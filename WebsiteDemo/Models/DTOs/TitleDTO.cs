using System.Runtime.Serialization;
namespace WebsiteDemo.Models.DTOs
{
    
    [DataContract(Name = "Title")]
    public class TitleDTO
    {
        [DataMember(Name = "TitleText")]
        public string TitleText { get; set; }
    }
}
