namespace NewsFeed.API.Infrastructure
{
    using Domain.Infrastructure;
    using Domain.Models;
    using Models;
    using System.Linq;

    public class ChannelRepository : IChannelRepository
    {
        private INewsFeedAPIContext _context;

        public ChannelRepository(INewsFeedAPIContext context)
        {
            _context = context;
        }

        public IQueryable<Channel> Channels
        {
            get
            {
                return _context.Channels;
            }
        }
    }
}