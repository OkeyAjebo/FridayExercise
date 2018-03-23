using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            this.Property(c => c.Name).HasMaxLength(250);
        }
    }
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(c => c.Title).HasMaxLength(250);
            this.Property(c => c.CreatedDate);
            this.Property(c => c.Body).HasMaxLength(250);
        }
    }
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.Property(c => c.FullName).HasMaxLength(250);
        }
    }
}
