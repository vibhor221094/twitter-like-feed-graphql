using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace twitter_feed_server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tweets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Handle = table.Column<string>(type: "TEXT", nullable: true),
                    TweetBody = table.Column<string>(type: "TEXT", nullable: true),
                    Comments = table.Column<int>(type: "INTEGER", nullable: false),
                    Retweets = table.Column<int>(type: "INTEGER", nullable: false),
                    Likes = table.Column<int>(type: "INTEGER", nullable: false),
                    Analytics = table.Column<int>(type: "INTEGER", nullable: false),
                    Verified = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Analytics", "Comments", "Handle", "Likes", "Name", "Retweets", "TweetBody", "Verified" },
                values: new object[,]
                {
                    { 1, 101, 10, "@adam435", 100, "Adam", 1, "me after 1 double rum and diet", false },
                    { 2, 101, 10, "@kevin6745", 100, "Kevin", 2, "\"My friend thinks over there you cute\" The friend:", true },
                    { 3, 101, 10, "@elon765", 100, "Elon", 3, "The double hands in the pocket", false },
                    { 4, 101, 10, "@andrew325", 100, "Andrew", 4, "(your text here)", false },
                    { 5, 101, 10, "@robert333", 100, "Robert", 5, "Relatives: What a strong handsome young man you've become... 12 y/o me:", false },
                    { 6, 101, 10, "@jessica6565", 100, "Jessica", 6, "Me leaving the pot in the sink because \"it needs to soak\"", false },
                    { 7, 101, 10, "@pam76676", 100, "Pam", 7, "me, when I show up on my day off", false },
                    { 8, 101, 10, "@leo8767", 100, "Leo", 8, "watching someone else get blamed for your fart", true },
                    { 9, 101, 10, "@rachel7777", 100, "Rachel", 9, "NO ONE: YOUR PARENTS FAMILY PHOTOS", false },
                    { 10, 101, 10, "@mohammad0909", 100, "Mohammad", 10, "My dog when I pick up a poo bag", false },
                    { 11, 101, 10, "@raj7878", 100, "Raj", 11, "Did you clog the toilet again?? Me:", false },
                    { 12, 101, 10, "@daniel9343", 100, "Daniel", 12, "How many memes did you post today? ME:", false },
                    { 13, 101, 10, "@jake3409", 100, "Jake", 13, "smurk and shrug", true },
                    { 14, 101, 10, "@hunter5326", 100, "Hunter", 14, "me when my friend posts a screenshot of our text messages on their story so everyone can see how funny i am", false },
                    { 15, 101, 10, "@sukh367", 100, "Sukhpreet", 15, "Everywhere I go....", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tweets");
        }
    }
}
