using System;

namespace RazorApp.Services
{
    public class ServiceExtensions
    {
        public static class ServiceCollectionExtensions
        {
            public static IServiceCollection AddServiceContracts(this IServiceCollection services)
                => services
                    .AddScoped(typeof(IBaseService<>), typeof(BaseService<>))
                    .AddScoped<IGroupService, GroupService>()
                    .AddScoped<IProviderService, ProviderService>();

            public static IServiceCollection AddService(this IServiceCollection services, string connectionString)
                => services
                    .AddRepository(connectionString)
                    .AddServiceContracts();
        }
    }
}
