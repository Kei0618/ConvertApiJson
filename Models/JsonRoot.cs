using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // 轉換postman api collection中的內容
    public class JsonRoot
    {
        [JsonPropertyName("info")]
        public RootInfo Info { get; set; } = new();

        [JsonPropertyName("item")]
        public List<RootItem> Items { get; set; } = new();

        [JsonPropertyName("auth")]
        public RootAuth Auth { get; set; } = new();

        [JsonPropertyName("event")]
        public List<RootEvent> Event { get; set; } = new();
    }
}