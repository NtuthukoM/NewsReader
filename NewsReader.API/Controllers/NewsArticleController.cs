using Microsoft.AspNetCore.Mvc;
using NewsReader.Application.Contracts;

namespace NewsReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsArticleController:ControllerBase
    {
        private readonly INewsItemRepository newsItemRepository;

        public NewsArticleController(INewsItemRepository newsItemRepository)
        {
            this.newsItemRepository = newsItemRepository;
        }

        [HttpGet("{shortLink}")]
        public async Task<IActionResult> Get(string shortLink)
        {
            var article = await newsItemRepository.GetNewsArticleAsync(shortLink);
            return Ok(article);
        }
    }
}
