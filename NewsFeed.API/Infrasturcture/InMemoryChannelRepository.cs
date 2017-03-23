using NewsFeed.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsFeed.Domain.Models;
using NewsFeed.API.Models;
using NewsFeed.API.Infrasturcture;

namespace NewsFeed.API.Infrastructure
{
    public class InMemoryChannelRepository : IChannelRepository
    {
        InMemoryDbSet<Channel> _channels = null;

        public IQueryable<Channel> Channels
        {
            get
            {
                if (_channels == null)
                {
                    _channels = new InMemoryDbSet<Channel>();
                    SeedData.Seed.Channels.ForEach(x => _channels.Add(x));
                }

                return _channels.AsQueryable();
            }
        }

        public void Dispose()
        {
        }
    }
}