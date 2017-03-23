using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using NewsFeed.API.Models;
using System.Linq.Expressions;
using NewsFeed.API.DTO;
using NewsFeed.Domain.Models;
using NewsFeed.Domain.Infrastructure;
using System.Web.Http.Cors;

namespace NewsFeed.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // allowing any client to access NewsFeed
    [RoutePrefix("api/Articles")]
    public class ArticlesController : ApiController
    {
        //private NewsFeedAPIContext db = new NewsFeedAPIContext();
        private IArticleRepository _repository;

        public ArticlesController(IArticleRepository repository)
        {
            _repository = repository;
        }

        private static readonly Expression<Func<Article, ArticleDto>> AsArticleDto =
            x => new ArticleDto
            {
                ArticleId = x.ArticleId,
                Title = x.Title,
                Channel = x.Channel.Name,
                Published = x.Published,
                Leader = x.Leader
            };

        private static readonly Expression<Func<Article, ArticleDetailDto>> AsArticleDetailsDto =
            x => new ArticleDetailDto
            {
                Title = x.Title,
                Channel = x.Channel.Name,
                Published = x.Published,
                Leader = x.Leader,
                Body = x.Body
            };

        // GET: api/Articles
        [Route("")]
        public IQueryable<ArticleDto> GetArticles()
        {
            return _repository.Articles.Include(c => c.Channel).Select(AsArticleDto);
        }

        // GET: api/Articles/5
        [Route("{id:int}")]
        [ResponseType(typeof(Article))]
        public async Task<IHttpActionResult> GetArticle(int id)
        {
            ArticleDto article = await _repository.Articles.Include(c => c.Channel).
                Where(b => b.ArticleId == id).
                Select(AsArticleDto).
                FirstOrDefaultAsync();
    
            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }

        [Route("{id:int}/details")]
        [ResponseType(typeof(ArticleDetailDto))]
        public async Task<IHttpActionResult> GetArticleDetail(int id)
        {
            var article = await _repository.Articles.Include(c => c.Channel).
                Where(a => a.ArticleId == id).
                Select(AsArticleDetailsDto).
                FirstOrDefaultAsync();
                              
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [Route("date/{published:datetime:regex(\\d{4}-\\d{1,2}-\\d{1,2})}")]
        [Route("date/{*published:datetime:regex(\\d{4}/\\d{1,2}/\\d{1,2})}")]  // '*' catch-all segments to match /yyyy/mm/dd 
        public IQueryable<ArticleDto> GetArticles(DateTime published)
        {
            return _repository.Articles.Include(c => c.Channel)
                .Where(a => a.Published <= published)
                .OrderBy(a => a.Published)
                .Select(AsArticleDto);
        }

        [Route("date/{channelName}/{published:datetime:regex(\\d{4}-\\d{1,2}-\\d{1,2})}")]
        [Route("date/{channelName}/{*published:datetime:regex(\\d{4}/\\d{1,2}/\\d{1,2})}")]  // '*' catch-all segments to match /yyyy/mm/dd 
        public IQueryable<ArticleDto> GetChannelArticles(DateTime published, string channelName)
        {
            return _repository.Articles.Include(c => c.Channel)
                .Where(a => a.Published <= published && a.Channel.Name.Equals(channelName, StringComparison.OrdinalIgnoreCase))
                .OrderBy(a => a.Published)
                .Select(AsArticleDto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repository.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArticleExists(int id)
        {
            return _repository.Articles.Count(e => e.ArticleId == id) > 0;
        }
    }
}