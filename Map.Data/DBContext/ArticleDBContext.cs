using Microsoft.EntityFrameworkCore;
using Map.Data.Entities;

namespace Map.Data.DBContext
{
    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }

        public ArticleDBContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
