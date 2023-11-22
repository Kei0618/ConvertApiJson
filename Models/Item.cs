using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // RootItem類別內的Item類別
    public class Item
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("request")]
        public Request Request { get; set; } = new();


        [JsonPropertyName("response")]
        public List<Response> Response { get; set; } = new();
    }
}