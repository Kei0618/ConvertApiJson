using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // JsonRoot類別內的response類別
    public class Response
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("originalRequest")]
        public OriginalRequest OriginalRequest { get; set; }


        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("_postman_previewlanguage")]
        public string Postman_previewlanguage { get; set; }

        [JsonPropertyName("header")]
        public List<Header> Header { get; set; } = new();


        [JsonPropertyName("cookie")]
        public JsonElement Cookie { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
    
    // response類別內的OriginalRequest類別
    public class OriginalRequest
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("header")]
        public JsonElement? Header { get; set; } = new();

        [JsonPropertyName("body")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Body? Body { get; set; } = null;

        [JsonPropertyName("url")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public JsonElement? Url { get; set; }=null;

    }

    // response類別內的Header類別
    public class Header
    {
        [JsonPropertyName("key")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }

        [JsonPropertyName("name")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}