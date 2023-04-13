using System.Text.Json.Serialization;

namespace Friable_mongo.Models
{
    public class Selector
    {
        

        [JsonPropertyName("@context")]
        public string Context { get; set; }
        public string Type { get; set; }
        public string? Region { get; set; }
        public string Value { get; set; }
    }
}
