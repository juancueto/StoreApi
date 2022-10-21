using Newtonsoft.Json;

namespace StoreBackend.DTO.V1
{
    public class Producto: ProductBase, IProductBase
    {
        

        [JsonProperty("rating")]
        public Rating rating { get; set; }
    }

    public interface IProductBase
    {
        [JsonProperty("id")]
        int id { get; set; }

        [JsonProperty("title")]
        string title { get; set; }

        [JsonProperty("price")]
        double price { get; set; }

        [JsonProperty("description")]
        string description { get; set; }

        [JsonProperty("category")]
        string category { get; set; }

        [JsonProperty("image")]
        Uri image { get; set; }
    }

    public abstract class ProductBase: IProductBase
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("image")]
        public Uri image { get; set; }
    }

}
