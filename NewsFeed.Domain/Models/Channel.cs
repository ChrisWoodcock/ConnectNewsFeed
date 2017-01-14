namespace NewsFeed.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Channel
    {
        public int ChannelId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}