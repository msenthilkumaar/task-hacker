using Flurl.Http;
using Microsoft.Extensions.Caching.Memory;

namespace hacker_news_bamboo_card.Models
{
    public class BestStoriesServices:IBestStoriesServices
    {
        private const string BaseUrl = "https://hacker-news.firebaseio.com/v0";
        private readonly ILogger<BestStoriesServices> _logger;
        public BestStoriesServices(ILogger<BestStoriesServices> logger)
        {
            _logger = logger;
        }

        public async Task<List<Story>> GetBestStoriesAsync(int count, CancellationToken cancellationToken = default)
        {
            var storyIds = await GetBestStoryIds();
            List<Story> stories = new ();
           
            await Parallel.ForEachAsync(storyIds.Take(count), async (storyId, cancellationToken) =>
            {
                var story = await GetStoryAsync(storyId);

                stories.Add(story);
            });
           
            return stories.OrderByDescending(s => s.Score).ToList(); ;
        }

        private async Task<List<int>> GetBestStoryIds()
        {
            _logger.LogInformation("Getting best Story Ids");

            List<int> response = await $"{BaseUrl}/beststories.json".GetJsonAsync<List<int>>();

            return response;
        }

        private async Task<Story> GetStoryAsync(int storyId)
        {
            _logger.LogInformation($"Getting Story for id {storyId}");
            Story response = await $"{BaseUrl}/item/{storyId}.json".GetJsonAsync<Story>();
            return response;
        }
    }
}
