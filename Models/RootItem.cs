using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // JsonRoot類別內的RootItem類別
    public class RootItem
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("item")]
        public List<Item> Item { get; set; } = new();
    }
}