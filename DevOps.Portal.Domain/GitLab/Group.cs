using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevOps.Portal.Domain.GitLab
{
    public class Group
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [JsonProperty(PropertyName = "parent_id")]
        public string ParentId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "visibility")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GroupVisibility Visibility { get; set; }    
    }
}
