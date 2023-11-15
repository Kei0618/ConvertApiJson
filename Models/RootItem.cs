using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public class RootItem
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("item")]
        public List<Item> Item { get; set; } = new();
    }
}