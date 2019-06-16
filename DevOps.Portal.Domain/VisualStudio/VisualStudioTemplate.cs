using System;
using Newtonsoft.Json;

namespace DevOps.Portal.Domain.VisualStudio
{
    public class VisualStudioTemplate
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }

        [JsonIgnore]
        public Uri Uri => new Uri(RepositoryUrl);
    }
}
