using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Energetic.WebApis.Contracts.Responses
{
    public class ODataCollection<T>
    {
        public ODataCollection(IEnumerable<T> items)
        {
            Items = items;
        }

        [JsonPropertyName("@odata.count")]
        public int Count { get; set; }

        [JsonPropertyName("value")]
        public IEnumerable<T> Items { get; set; } = new List<T>();
    }
}
