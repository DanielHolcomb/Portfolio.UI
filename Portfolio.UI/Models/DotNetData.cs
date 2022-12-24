using System.Text.Json.Serialization;

namespace Portfolio.UI.Models
{
    public class DotNetData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }
}
