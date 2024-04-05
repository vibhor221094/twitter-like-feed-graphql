using Microsoft.EntityFrameworkCore;
using twitter_feed_server.DB;
using twitter_feed_server.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TwitterDbContext>(options =>
{
    var folder = Environment.SpecialFolder.LocalApplicationData;
    var path = Environment.GetFolderPath(folder);
    var dbPath = System.IO.Path.Join(path, "tweets.db");
    options.UseSqlite($"Data Source={dbPath}");
    options.LogTo(Console.WriteLine, LogLevel.Information);
});

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .RegisterDbContext<TwitterDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowUI",
                      policy =>
                      {
                          policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                      });
});

var app = builder.Build();

app.UseCors("AllowUI");

app.MapGraphQL();

app.Run();