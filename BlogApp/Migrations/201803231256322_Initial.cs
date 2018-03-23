namespace BlogApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(nullable: false),
                        Body = c.String(maxLength: 250),
                        Blog_ID = c.Int(),
                        Author_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blogs", t => t.Blog_ID)
                .ForeignKey("dbo.Authors", t => t.Author_ID)
                .Index(t => t.Blog_ID)
                .Index(t => t.Author_ID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_ID", "dbo.Authors");
            DropForeignKey("dbo.Posts", "Blog_ID", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Author_ID" });
            DropIndex("dbo.Posts", new[] { "Blog_ID" });
            DropTable("dbo.Authors");
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}
