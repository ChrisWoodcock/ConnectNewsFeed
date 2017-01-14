using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsFeed.API.DTO
{
    public class ArticleDto
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Channel { get; set; }
        public string Leader { get; set; }
        public DateTime Published { get; set; }
    }
}