using twitter_feed_server.DB;
using twitter_feed_server.Models;

namespace twitter_feed_server.Queries
{
    public class Query
    {
        [UsePaging(DefaultPageSize = 5), UseProjection]
        public IQueryable<Tweet> GetTweets(TwitterDbContext twitterDbContext)
        {
            return twitterDbContext.Tweets;
        }
    }
}