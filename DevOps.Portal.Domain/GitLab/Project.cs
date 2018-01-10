using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DevOps.Portal.Domain.GitLab
{
    public class Project
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [JsonProperty(PropertyName = "namespace_id")]
        public string GroupId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "visibility")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GroupVisibility Visibility { get; set; }

        [JsonProperty(PropertyName = "http_url_to_repo")]
        public string HttpUrl { get; set; }
    }
}
