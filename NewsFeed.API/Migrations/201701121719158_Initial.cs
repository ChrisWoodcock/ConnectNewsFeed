namespace NewsFeed.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Published = c.DateTime(nullable: false),
                        Title = c.String(),
                        Leader = c.String(),
                        Body = c.String(),
                        ChannelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Channels", t => t.ChannelId, cascadeDelete: true)
                .Index(t => t.ChannelId);
            
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        ChannelId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ChannelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "ChannelId", "dbo.Channels");
            DropIndex("dbo.Articles", new[] { "ChannelId" });
            DropTable("dbo.Channels");
            DropTable("dbo.Articles");
        }
    }
}
