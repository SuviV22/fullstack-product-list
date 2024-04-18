using Newtonsoft.Json;

namespace backend_csharp.Models
{
    public class Product
    {
        [JsonProperty("id")] public string Id { get; set; } = string.Empty;
        [JsonProperty("name")] public string Name { get; set; } = string.Empty;
        [JsonProperty("description")] public string Description { get; set; } = string.Empty;
        [JsonProperty("basePrice")] public double BasePrice { get; set; } = 0;
        [JsonProperty("price")] public double Price { get; set; } = 0;
    }
}
