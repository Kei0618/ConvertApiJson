using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public class RootAuth
    {
        [JsonPropertyName("type")]
        public string? AuthType { get; set; }

        [JsonPropertyName("bearer")]
        public Bearer Bearer { get; set; } = new();
    }
    public class Bearer
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }
}