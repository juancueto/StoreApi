using Newtonsoft.Json;

namespace StoreBackend.DTO.V1
{
    public class Rating
    {
        [JsonProperty("rate")]
        public double rate { get; set; }

        [JsonProperty("count")]
        public long count { get; set; }
    }
}
