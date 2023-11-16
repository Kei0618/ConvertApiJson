using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class JsonRoot
    {
        [JsonProperty("info")]
        public RootInfo Info { get; set; } = new();

        [JsonProperty("item")]
        public List<RootItem> Items { get; set; } = new();

        [JsonProperty("auth")]
        public RootAuth Auth { get; set; } = new();

        [JsonProperty("event")]
        public List<RootEvent> Event { get; set; } = new();
    }
}