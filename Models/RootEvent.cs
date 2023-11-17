using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public class RootEvent
    {
        [JsonPropertyName("listen")]
        public string? Listen { get; set; }
        
        [JsonPropertyName("script")]
        public Script Script { get; set; } = new();

    }
    
    public class Script
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("exec")]
        public List<string> Exec { get; set; } = new();
    }
}