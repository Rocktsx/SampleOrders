using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using OrdersService.Application;
using OrdersService.Infrastructure;
using OrdersService.Services;
using Microsoft.IdentityModel.Logging;

namespace OrdersService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddGrpc();
             
            services.AddEntityFrameworkSqlServer().AddDbContext<OrderDbContext>(options =>
            {
                 
                options.UseSqlServer(Configuration["ConnectionString"], sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(OrderDbContext).GetTypeInfo().Assembly.GetName().Name);
                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                });
                
            },ServiceLifetime.Scoped);

            services.AddScoped<IProductApplication, ProductApplication>();
            services.AddScoped<IOrderApplication, OrderApplication>();

            services.AddCors(options =>
            {
                options.AddPolicy("CORS", corsBuilder =>
                {
                    corsBuilder.AllowAnyOrigin();
                    corsBuilder.AllowAnyHeader();
                    corsBuilder.AllowAnyMethod();
                });
            });
            IdentityModelEventSource.ShowPII = true;

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options => {
                    options.Authority = "http://localhost:5000";
                    options.RequireHttpsMetadata = false;
                    options.Audience = "orderserviceapi";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("CORS");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<ProductService>();
                endpoints.MapGrpcService<OrderService>();
                endpoints.MapControllers();
            });
        }
    }
}
