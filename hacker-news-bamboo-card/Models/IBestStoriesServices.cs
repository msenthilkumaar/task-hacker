namespace hacker_news_bamboo_card.Models
{
    public interface IBestStoriesServices
    {
        public Task<List<Story>> GetBestStoriesAsync(int count, CancellationToken cancellationToken);
    }
}
