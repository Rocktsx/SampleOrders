using System;  
using Microsoft.AspNetCore.Hosting; 
using Microsoft.Extensions.Logging;  
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace OrdersService.Infrastructure.Extensions
{
    public static class WebHostMigrationExtensions
    {
        public static IHost MigrateDbContext<TDbContext>(this IHost host,
            Action<TDbContext, IServiceProvider> seeder) where TDbContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<TDbContext>>();
                var context = services.GetService<TDbContext>();

                try
                {
                    context.Database.Migrate();
                    seeder(context, services);

                    logger.LogInformation($"执行DbContext{typeof(TDbContext).Name} seed执行成功！");
                }
                catch (Exception ex)
                {
                    logger.LogError($"执行DbContext{typeof(TDbContext).Name} seed执行失败！");
                    logger.LogError(ex.Message);
                }

            }
            return host;
        }
    }
}