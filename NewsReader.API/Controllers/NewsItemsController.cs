using Microsoft.AspNetCore.Mvc;
using NewsReader.Application.Contracts;
using NewsReader.Application.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsItemsController : ControllerBase
    {
        private readonly INewsItemRepository repository;

        public NewsItemsController(INewsItemRepository repository)
        {
            this.repository = repository;
        }
        // GET: api/<NewsItemsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await repository.GetNewsItemsAsync();
            return Ok(items);
        }

    }
}
