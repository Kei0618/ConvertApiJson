using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConvertApiJson
{
    // PostManApiCollection Json檔案的內容裝入PostManApiContent類別中
    
    // Options類別內的Raw類別
    public class Raw
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }


    }

    // Body類別內的Options類別
    public class Options
    {
        [JsonPropertyName("raw")]
        public Raw Raw { get; set; } = new();

    }

    // Request以及OriginalRequest類別內的Body類別
    public class Body
    {
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }

        [JsonPropertyName("raw")]
        public string? Raw { get; set; }

        [JsonPropertyName("options")]
        public Options Options { get; set; } = new();
    }


    // Response類別內的Header類別
    public class Header
    {
        [JsonPropertyName("key")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }

        [JsonPropertyName("name")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }

    // Response類別內的OriginalRequest類別
    public class OriginalRequest
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }

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

    // PostManApiContent類別內的Response類別
    public class Response
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("originalRequest")]
        public OriginalRequest OriginalRequest { get; set; }


        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("_postman_previewlanguage")]
        public string Postman_previewlanguage { get; set; }

        [JsonPropertyName("header")]
        public List<Header> Header { get; set; } = new();


        [JsonPropertyName("cookie")]
        public JsonElement Cookie { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }

    // PostManApiContent類別內的Request類別
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

    // ItemList類別內的Item類別
    public class Item
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("request")]
        public Request Request { get; set; } = new();


        [JsonPropertyName("response")]
        public List<Response> Response { get; set; } = new();
    }

    // AuthList類別內的Bearer類別
    public class Bearer
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }

    // EventList類別內的Script類別
    public class Script
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("exec")]
        public List<string> Exec { get; set; } = new();
    }

    // PostManApiContent類別內的Info類別
    public class Info
    {
        [JsonPropertyName("_postman_id")]
        public string? Postman_id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("schema")]
        public string? Schema { get; set; }

        [JsonPropertyName("_exporter_id")]
        public string? Exporter_id { get; set; }

        [JsonPropertyName("_collection_link")]
        public string? Collection_link { get; set; }
    }

    // PostManApiContent類別內的ItemList類別
    public class ItemList
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("item")]
        public List<Item> Item { get; set; } = new();
    }

    // PostManApiContent類別內的AuthList類別
    public class AuthList
    {
        [JsonPropertyName("type")]
        public string? AuthType { get; set; }

        [JsonPropertyName("bearer")]
        public Bearer Bearer { get; set; } = new();
    }

    // PostManApiContent類別內的EventList類別
    public class EventList
    {
        [JsonPropertyName("listen")]
        public string? Listen { get; set; }

        [JsonPropertyName("script")]
        public Script Script { get; set; } = new();

    }

    // 原postman api collection json內容的類別
    public class PostManApiContent
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; } = new();

        [JsonPropertyName("item")]
        public List<ItemList> Items { get; set; } = new();

        [JsonPropertyName("auth")]
        public AuthList Auth { get; set; } = new();

        [JsonPropertyName("event")]
        public List<EventList> Event { get; set; } = new();
    }

    // 轉換後的PostMan API Collection json內容的新類別
    public class NewPostManApiContent
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; } = new();

        [JsonPropertyName("item")]
        public List<Item> Items { get; set; } = new();

        [JsonPropertyName("auth")]
        public AuthList Auth { get; set; } = new();

        [JsonPropertyName("event")]
        public List<EventList> Event { get; set; } = new();
    }

}