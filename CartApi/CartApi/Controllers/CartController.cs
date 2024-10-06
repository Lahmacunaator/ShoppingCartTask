using CartApi.Entities;
using CartApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CartApi.Controllers;

[Route("api/{userId:int}[controller]")]
[ApiController]
public class CartController
{
    [HttpGet]
    public async Task<ActionResult<Cart>> GetCart()
    {
        var cart = new GetCartModel([
            new Item { Id = 1, Name = "Potato", Price = 31.69m },
            new Item { Id = 2, Name = "Kebab", Price = 21.15m },
            new Item { Id = 3, Name = "Tomato", Price = 41.26m },
            new Item { Id = 4, Name = "Lahmacun", Price = 51.37m },
            new Item { Id = 5, Name = "Cat", Price = 61.48m }
        ]);

        return Ok(cart);
    }
}