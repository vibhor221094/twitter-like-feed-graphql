namespace twitter_feed_server.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Handle { get; set; }
        public string? TweetBody { get; set; }
        public int Comments { get; set; }
        public int Retweets { get; set; }
        public int Likes { get; set; }
        public int Analytics { get; set; }
        public bool Verified { get; set; }
    }
}