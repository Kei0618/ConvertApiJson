using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class RootAuth
    {
        [JsonProperty("type")]
        public string? AuthType { get; set; }

        [JsonProperty("bearer")]

        public Bearer Bearer { get; set; } = new();
    }
    public class Bearer
    {
        [JsonProperty("token")]
        public string? Token { get; set; }
    }
}