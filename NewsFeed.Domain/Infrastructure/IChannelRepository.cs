namespace NewsFeed.Domain.Infrastructure
{
    using System;
    using System.Linq;
    using NewsFeed.Domain.Models;

    public interface IChannelRepository : IDisposable
    {
        IQueryable<Channel> Channels { get; }
    }
}
