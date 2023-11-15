using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class RootInfo
    {
        [JsonProperty("_postman_id")]
        public string? Postman_id { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("schema")]
        public string? Schema { get; set; }

        [JsonProperty("_exporter_id")]
        public string? Exporter_id { get; set; }

        [JsonProperty("_collection_link")]
        public string? Collection_link { get; set; }
    }
}