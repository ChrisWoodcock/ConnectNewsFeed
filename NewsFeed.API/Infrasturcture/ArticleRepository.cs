using NewsFeed.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsFeed.Domain.Models;
using NewsFeed.API.Models;

namespace NewsFeed.API.Infrastructure
{
    public class ArticleRepository : IArticleRepository
    {
        private INewsFeedAPIContext _context;

        public ArticleRepository(INewsFeedAPIContext context)
        {
            _context = context;
        }

        public IQueryable<Article> Articles
        {
            get
            {
                return _context.Articles;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}