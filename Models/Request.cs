using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class Request
    {
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Auth? Auth { get; set; } = new();

        [JsonProperty("method")]
        public string? Method { get; set; }

        [JsonProperty("header")]
        public List<object> Header { get; set; } = new();
        [JsonProperty("url")]
        public object? Url { get; set; }

        [JsonProperty("body")]
        public Body Body { get; set; } = new();
    }

    public class Auth
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

    }



    public class Body
    {
        [JsonProperty("mode")]
        public string? Mode { get; set; }

        [JsonProperty("raw")]
        public string? Raw { get; set; }
        [JsonProperty("options")]
        public Options Options { get; set; } = new();
    }

    public class Options
    {
        [JsonProperty("raw")]
        public Raw Raw { get; set; } = new();
    }

    public class Raw
    {
        [JsonProperty("language")]
        public string? Language { get; set; }
    }
}