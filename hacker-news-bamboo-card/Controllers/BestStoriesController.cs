using hacker_news_bamboo_card.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace hacker_news_bamboo_card.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestStoriesController : ControllerBase
    {
        private readonly ILogger<BestStoriesController> _logger;
        private readonly IBestStoriesServices _storiesService;
        public BestStoriesController(ILogger<BestStoriesController> logger, IBestStoriesServices storiesService)
        {
            _logger = logger;
            _storiesService = storiesService;
        }

        [HttpGet("{numberOfStoriesToLoad}")]
        public async Task<ActionResult<Story[]>> Get(int numberOfStoriesToLoad, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Getting {numberOfStoriesToLoad} best stories");
            return Ok(await _storiesService.GetBestStoriesAsync(numberOfStoriesToLoad, cancellationToken));
        }
    }
}
