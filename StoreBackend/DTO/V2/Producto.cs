using Newtonsoft.Json;
using StoreBackend.DTO.V1;

namespace StoreBackend.DTO.V2
{
    public class Producto: ProductBase, IProductBase
    {
        [JsonProperty("internalId")]
        public Guid InternalId { get; set; }
    }
}
