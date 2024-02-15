using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace hacker_news_bamboo_card.Models
{
    public class Story
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("by")]
        public string postedby { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("descendants")]
        public int commentcount { get; set; }
        //public int Id { get; set; }
        //public List<int> Kids { get; set; }
        //public string Type { get; set; }
    }
}
