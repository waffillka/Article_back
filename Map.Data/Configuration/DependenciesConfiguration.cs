using Map.Data.DBContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Map.Data.Configuration
{
    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureSqlArticleContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ArticleDBContext>(opts =>
                opts.UseSqlServer(connectionString, b => b.MigrationsAssembly("Map.Data")));

            return services;
        }
    }
}
