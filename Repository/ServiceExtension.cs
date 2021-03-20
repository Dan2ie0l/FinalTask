using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RazorApp.Repository;
using RazorApp.Repository.Repo;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
            => services.AddDbContext<ApplicationContext>(con => con.UseSqlServer(connectionString));

        public static IServiceCollection AddRepositoryContracts(this IServiceCollection services)
            => services
                .AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>))
                .AddScoped<IGroupRepository, GroupRepository>()
                .AddScoped<IProviderRepository, ProviderRepository>();

        public static IServiceCollection AddRepository(this IServiceCollection services, string connectionString)
            => services
                .AddDbContext(connectionString)
                .AddRepositoryContracts();
    }
}
