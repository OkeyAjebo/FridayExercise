namespace BlogApp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogApp.BlogAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogApp.BlogAppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var post1 = new Post()
            {
                Title = "Champions League",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis magna sodales, euismod odio at, consequat ante."
            };
            var post2 = new Post()
            {
                Title = "2019 Election",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis magna sodales, euismod odio at, consequat ante."
            };
            var post3 = new Post()
            {
                Title = "Space Travel",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis magna sodales, euismod odio at, consequat ante."
            };
            var post4 = new Post()
            {
                Title = "Datebase Future",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis magna sodales, euismod odio at, consequat ante."
            };
            var post5 = new Post()
            {
                Title = "Lola weds Muna",
                CreatedDate = DateTime.Now,
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec quis magna sodales, euismod odio at, consequat ante."
            };

            var blog1 = new Blog()
            {
                Name = "Muna's Blog",
                Posts = new List<Post>
                {
                    post4,
                    post5
                }
            };

            var blog2 = new Blog()
            { 
                Name = "Linda Ikeji's Blog",
                Posts = new List<Post>
                {
                    post1,
                    post2
                }
            };


            var author1 = new Author()
            {
                FullName = "Ochiaka Okechukwu",
                Posts = new List<Post>
                {
                    post3
                }
            };
            var author2 = new Author()
            {
                FullName = "Oriahi Emmanuel",
                Posts = new List<Post>
                {
                    post1,
                    post2
                }
            };

            
            context.Set<Blog>().AddOrUpdate(c => c.Name, blog1);
            context.Set<Blog>().AddOrUpdate(c => c.Name, blog1);
            context.Set<Author>().AddOrUpdate(c => c.FullName, author1);
            context.Set<Author>().AddOrUpdate(c => c.FullName, author2);

            context.SaveChanges();

        }
    }
}
