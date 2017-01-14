using NewsFeed.Domain.Models;
namespace NewsFeed.Domain.Infrastructure
{
    using System;
    using System.Linq;

    public interface IArticleRepository : IDisposable
    {
        IQueryable<Article> Articles { get; }
    }
}
