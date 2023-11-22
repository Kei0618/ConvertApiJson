using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // JsonRoot類別內的RootEvent類別
    public class RootEvent
    {
        [JsonPropertyName("listen")]
        public string? Listen { get; set; }

        [JsonPropertyName("script")]
        public Script Script { get; set; } = new();

    }

    // RootEvent類別內的Script類別
    public class Script
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("exec")]
        public List<string> Exec { get; set; } = new();
    }
}