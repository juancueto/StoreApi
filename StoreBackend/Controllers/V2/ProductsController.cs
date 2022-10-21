using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBackend.DTO.V2;
using System.Text.Json;

namespace StoreBackend.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private const string ApiProductsUrl = "https://fakestoreapi.com/products";
        private readonly HttpClient _httpClient;

        public ProductsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            _httpClient.DefaultRequestHeaders.Clear();

            var response = await _httpClient.GetStreamAsync(ApiProductsUrl);

            var productsData = await JsonSerializer.DeserializeAsync<Producto[]>(response);

            foreach (var product in productsData)
            {
                product.InternalId = Guid.NewGuid();
            }

            return Ok(productsData);
        }
    }
}
