namespace NewsFeed.API.Models
{
    using NewsFeed.Domain.Models;
    using System;

    public interface INewsFeedAPIContext : IDisposable
    {
        System.Data.Entity.DbSet<Article> Articles { get; set; }

        System.Data.Entity.DbSet<Channel> Channels { get; set; }
    }
}