using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Affiliate Marketing Plan",
                Description = "With more than 20% of affiliate marketers each making over $50,000 a year, and well over half of those in the six figure bracket, the upside potential for a nice annual income looks quite promising for anyone who is looking for a new source of revenue.",
                ImageUrl = "https://www.ebookjunkie.com/sites/default/files/ebook_images/affiliate_marketing_plan_profit_bundle.jpg",
                Price = 9.99m

            },
            new Product
            {
                Id = 2,
                Title = "Email Marketing Success",
                Description = "With more than 205 billion emails being sent and received every day if your business isn't taking advantage of this powerful and massive marketing channel, then you are missing out on a highly effective way to reach your target audience.",
                ImageUrl = "https://www.ebookjunkie.com/sites/default/files/ebook_images/email_marketing_success2.jpg",
                Price = 5.99m

            },
            new Product
            {
                Id = 3,
                Title = "The Productive Solopreneur",
                Description = "Being a solopreneur means being an entrepreneur that runs everything themselves. There are countless advantages to this kind of business model, and thanks to the web, it's now more feasible for more people than ever before.",
                ImageUrl = "https://www.ebookjunkie.com/sites/default/files/ebook_images/productive_solopreneur_0.jpg",
                Price = 7.99m

            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
