using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // JsonRoot類別內的RootAuth類別
    public class RootAuth
    {
        [JsonPropertyName("type")]
        public string? AuthType { get; set; }

        [JsonPropertyName("bearer")]
        public Bearer Bearer { get; set; } = new();
    }

    // RootAuth類別內的bearer類別
    public class Bearer
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }
}