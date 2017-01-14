using NewsFeed.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsFeed.API.Models
{
    public class NewsFeedAPIContext : DbContext, INewsFeedAPIContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NewsFeedAPIContext() : base("name=NewsFeedAPIContext")
        {
        }

        public System.Data.Entity.DbSet<Article> Articles { get; set; }

        public System.Data.Entity.DbSet<Channel> Channels { get; set; }
    }
}
