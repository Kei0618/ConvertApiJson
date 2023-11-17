using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public class RootInfo
    {
        [JsonPropertyName("_postman_id")]
        public string? Postman_id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("schema")]
        public string? Schema { get; set; }

        [JsonPropertyName("_exporter_id")]
        public string? Exporter_id { get; set; }

        [JsonPropertyName("_collection_link")]
        public string? Collection_link { get; set; }
    }
}