using NewsFeed.Domain.Models;
namespace NewsFeed.Domain.Infrastructure
{
    using System.Linq;

    public interface IChannelRepository
    {
        IQueryable<Channel> Channels { get; }
    }
}
