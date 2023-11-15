using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class Item
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; } = new();


        [JsonProperty("response")]
        public List<Response> Response { get; set; } = new();
    }
}