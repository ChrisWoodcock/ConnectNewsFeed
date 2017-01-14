namespace NewsFeed.Domain.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Article
    {
        public int ArticleId { get; set; }

        public DateTime Published { get; set; }

        public string Title { get; set; }

        public string Leader { get; set; }

        public string Body { get; set; }

        public int ChannelId { get; set; }

        [ForeignKey("ChannelId")]
        public Channel Channel { get; set; }
    }
}