using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public class Request
    {
        [JsonPropertyName("auth")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Auth? Auth { get; set; } = null;

        [JsonPropertyName("method")]
        public string? Method { get; set; }

        [JsonPropertyName("header")]
        public List<object> Header { get; set; } = new();

        [JsonPropertyName("body")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Body? Body { get; set; } = null;

        [JsonPropertyName("url")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public JsonElement? Url { get; set; } = null;

    }

    public class Auth
    {
        [JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

    }



    public class Body
    {
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }

        [JsonPropertyName("raw")]
        public string? Raw { get; set; }

        [JsonPropertyName("options")]
        public Options Options { get; set; } = new();
    }

    public class Options
    {
        [JsonPropertyName("raw")]
        public Raw Raw { get; set; } = new();
    }

    public class Raw
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }
    }

    public class Url
    {
        [JsonPropertyName("raw")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Raw { get; set; }

        [JsonPropertyName("host")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Host { get; set; } = null;

        [JsonPropertyName("path")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Path { get; set; } = null;

        [JsonPropertyName("variable")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Variable>? Variable { get; set; } = null;

        [JsonPropertyName("query")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Query>? Query { get; set; } = null;

    }

    public class Variable
    {
        [JsonPropertyName("key")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }
    }

    public class Query
    {
        [JsonPropertyName("key")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }
    }
}