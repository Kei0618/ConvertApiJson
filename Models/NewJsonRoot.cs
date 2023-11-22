using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson.Models
{
    //  轉換後的PostMan API Collection json內容的新類別
    public class NewJsonRoot
    {
        [JsonPropertyName("info")]
        public RootInfo Info { get; set; } = new();

        [JsonPropertyName("item")]
        public List<Item> Items { get; set; } = new();

        [JsonPropertyName("auth")]
        public RootAuth Auth { get; set; } = new();

        [JsonPropertyName("event")]
        public List<RootEvent> Event { get; set; } = new();
    }
}