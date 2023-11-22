using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    // JsonRoot類別內的Request類別
    public class Request
    {
        [JsonPropertyName("auth")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Auth? Auth { get; set; } = null;

        [JsonPropertyName("method")]
        public string? Method { get; set; }

        [JsonPropertyName("header")]
        public JsonElement? Header { get; set; } = new();

        [JsonPropertyName("body")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Body? Body { get; set; } = null;

        [JsonPropertyName("url")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public JsonElement? Url { get; set; } = null;

    }

    // Request類別內的auth類別
    public class Auth
    {
        [JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

    }

    // Request類別內的Body類別
    public class Body
    {
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }

        [JsonPropertyName("raw")]
        public string? Raw { get; set; }

        [JsonPropertyName("options")]
        public Options Options { get; set; } = new();
    }

    // Body類別內的Options類別
    public class Options
    {
        [JsonPropertyName("raw")]
        public Raw Raw { get; set; } = new();
    }

    // Options類別內的Raw類別
    public class Raw
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }
    }


}