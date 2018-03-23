using System.Data.Entity;

namespace BlogApp
{
    public class BlogAppDbContext : DbContext
    {
        public BlogAppDbContext() : base("BlogAppDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BlogAppDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new AuthorMap());
        }
    }
}
