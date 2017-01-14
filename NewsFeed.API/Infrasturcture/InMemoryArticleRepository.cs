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
    public class InMemoryArticleRepository : IArticleRepository
    {
        InMemoryDbSet<Article> _articles = null;

        public IQueryable<Article> Articles
        {
            get
            {
                if(_articles == null)
                {
                    _articles = new InMemoryDbSet<Article>();
                    SeedData.Seed.Articles.ForEach(x => _articles.Add(x));
                }

                return _articles.AsQueryable();   
            }
        }
        
        public void Dispose()
        {
        }
    }
}