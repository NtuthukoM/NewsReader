using Microsoft.AspNetCore.Mvc;
using NewsReader.Application.Contracts;
using NewsReader.Application.Repositories;

namespace NewsReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController: ControllerBase
    {
        private readonly INewsItemRepository repository;

        public CategoriesController(INewsItemRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await repository.GetNewsCategoroiesAsync();
            return Ok(items);
        }

    }
}
