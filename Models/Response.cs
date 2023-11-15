using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class Response
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("originalRequest")]
        public OriginalRequest OriginalRequest { get; set; }


        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("_postman_previewlanguage")]
        public string Postman_previewlanguage { get; set; }

        [JsonProperty("header")]
        public List<Header> Header { get; set; } = new();


        [JsonProperty("cookie")]
        public List<object> Cookie { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
    
    public class OriginalRequest
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("header")]
        public List<object> Header { get; set; } = new();

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public Body? Body { get; set; } = null;

        [JsonProperty("url")]
        public object? Url { get; set; }

    }

    public class Header
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }
    }
}