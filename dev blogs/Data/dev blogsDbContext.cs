using dev_blogs.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace dev_blogs.Data
{
    public class dev_blogsDbContext : DbContext
    {
        public dev_blogsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
