using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //private static readonly List<Order> Orders = new();

        //// Let's assume the product details are fetched from the ProductService API.
        //private readonly HttpClient _httpClient;

        //public OrdersController(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}

        //[HttpPost]
        //public async Task<IActionResult> PlaceOrder([FromBody] Order order)
        //{
        //    // Simulating a call to ProductService to fetch product details.
        //    var productResponse = await _httpClient.GetFromJsonAsync<Product>($"http://localhost:5000/api/products/{order.ProductId}");
        //    if (productResponse == null) return NotFound("Product not found");

        //    // Calculate total price
        //    order.TotalPrice = productResponse.Price * order.Quantity;

        //    Orders.Add(order);
        //    return Ok(order);
        //}

        [HttpGet]
        public IActionResult GetOrders()
        {
            //return Ok(Orders);
            return Ok("this from Oders Service");
        }
    }
}
