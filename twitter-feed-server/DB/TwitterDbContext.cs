using Microsoft.EntityFrameworkCore;
using twitter_feed_server.Models;

namespace twitter_feed_server.DB
{
    public class TwitterDbContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }

        public TwitterDbContext(DbContextOptions<TwitterDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>().HasData(
                new Tweet
                {
                    Id = 1,
                    Name = "Adam",
                    Handle = "@adam435",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 1,
                    TweetBody = "me after 1 double rum and diet",
                    Verified = false
                },
                new Tweet
                {
                    Id = 2,
                    Name = "Kevin",
                    Handle = "@kevin6745",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 2,
                    TweetBody = "\"My friend thinks over there you cute\" The friend:",
                    Verified = true
                },
                new Tweet
                {
                    Id = 3,
                    Name = "Elon",
                    Handle = "@elon765",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 3,
                    TweetBody = "The double hands in the pocket",
                    Verified = false
                },
                new Tweet
                {
                    Id = 4,
                    Name = "Andrew",
                    Handle = "@andrew325",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 4,
                    TweetBody = "(your text here)",
                    Verified = false,

                },
                new Tweet
                {
                    Id = 5,
                    Name = "Robert",
                    Handle = "@robert333",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 5,
                    TweetBody = "Relatives: What a strong handsome young man you've become... 12 y/o me:",
                    Verified = false
                },
                new Tweet
                {
                    Id = 6,
                    Name = "Jessica",
                    Handle = "@jessica6565",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 6,
                    TweetBody = "Me leaving the pot in the sink because \"it needs to soak\"",
                    Verified = false
                },
                new Tweet
                {
                    Id = 7,
                    Name = "Pam",
                    Handle = "@pam76676",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 7,
                    TweetBody = "me, when I show up on my day off",
                    Verified = false
                },
                new Tweet
                {
                    Id = 8,
                    Name = "Leo",
                    Handle = "@leo8767",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 8,
                    TweetBody = "watching someone else get blamed for your fart",
                    Verified = true
                },
                new Tweet
                {
                    Id = 9,
                    Name = "Rachel",
                    Handle = "@rachel7777",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 9,
                    TweetBody = "NO ONE: YOUR PARENTS FAMILY PHOTOS",
                    Verified = false
                },
                new Tweet
                {
                    Id = 10,
                    Name = "Mohammad",
                    Handle = "@mohammad0909",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 10,
                    TweetBody = "My dog when I pick up a poo bag",
                    Verified = false
                },
                new Tweet
                {
                    Id = 11,
                    Name = "Raj",
                    Handle = "@raj7878",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 11,
                    TweetBody = "Did you clog the toilet again?? Me:",
                    Verified = false
                },
                new Tweet
                {
                    Id = 12,
                    Name = "Daniel",
                    Handle = "@daniel9343",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 12,
                    TweetBody = "How many memes did you post today? ME:",
                    Verified = false
                },
                new Tweet
                {
                    Id = 13,
                    Name = "Jake",
                    Handle = "@jake3409",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 13,
                    TweetBody = "smurk and shrug",
                    Verified = true
                },
                new Tweet
                {
                    Id = 14,
                    Name = "Hunter",
                    Handle = "@hunter5326",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 14,
                    TweetBody = "me when my friend posts a screenshot of our text messages on their story so everyone can see how funny i am",
                    Verified = false
                },
                new Tweet
                {
                    Id = 15,
                    Name = "Sukhpreet",
                    Handle = "@sukh367",
                    Comments = 10,
                    Likes = 100,
                    Analytics = 101,
                    Retweets = 15,
                    TweetBody = "Everywhere I go....",
                    Verified = false
                }
            );
        }
    }
}
