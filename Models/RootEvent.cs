using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class RootEvent
    {
        [JsonProperty("listen")]
        public string? Listen { get; set; }

        public Script Script { get; set; } = new();

    }
    
    public class Script
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("exec")]
        public List<string> Exec { get; set; } = new();
    }
}