using twitter_feed_server.DB;
using twitter_feed_server.Models;

namespace twitter_feed_server.Queries
{
    public class Query
    {
        [UseDbContext(typeof(TwitterDbContext))]
        [UsePaging(DefaultPageSize = 5)]
        public IQueryable<Tweet> GetTweets(TwitterDbContext twitterDbContext)
        {
            return twitterDbContext.Tweets;
        }
    }
}