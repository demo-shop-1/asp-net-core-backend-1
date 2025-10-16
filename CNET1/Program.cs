using CNET1.Configuration;
using CNET1.Exceptions;
using CNET1.Features.Products.Adapters.DB;
using CNET1.Features.Products.Application;
using CNET1.Features.Products.Application.Validations;
using CNET1.Features.Products.Domain.Ports;
using CNET1.Features.Products.Domain.PORTS;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Scalar.AspNetCore;

namespace CNET1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole(options =>
            {
                options.FormatterName = ConsoleFormatterNames.Simple;
            })
            .AddSimpleConsole(opt =>
            {
                opt.TimestampFormat = "[dd/MM/yyyy HH:mm:ss] ";
                opt.SingleLine = true;
            });
            builder.Logging.AddDebug();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi(options =>
            {
                options.AddDocumentTransformer((document, context, CancellationToken) =>
                {
                    document.Info.Title = "Demo Shop 1";
                    document.Info.Description = "Backend with ASP.NET 9 Core Web API";
                    document.Info.Version = "v1";
                    return Task.CompletedTask;
                });
            });

            // Set DbContext
            string connection = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";
            builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseMySql(connection, ServerVersion.AutoDetect(connection))
            );

            // Dependency Injection for Application Services
            ConfigureServices(builder.Services);

            var app = builder.Build();
            app.Logger.LogInformation("Application Starting...");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.MapScalarApiReference(options =>
                {
                    options.WithTitle("Scalar Docs API for Demo-Shop-1")
                    .WithTheme(ScalarTheme.DeepSpace)
                    .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
                });
            }

            // Global Exception Handler
            app.UseMiddleware<AppExceptionHandler>();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Util Services
            services.AddScoped(typeof(AppBaseUtil<>), typeof(ServiceHelper<>));
            services.AddKeyedScoped(typeof(AppBaseUtil<>), "controller", typeof(ControllerHelper<>));
            services.AddKeyedScoped(typeof(AppBaseUtil<>), "service", typeof(ServiceHelper<>));

            // Business Services
            services.AddScoped<IProductCommandService, ProductCommandApplication>();
            services.AddScoped<IProductQueryService, ProductQueryApplication>();
            services.AddScoped<IProductCommandOutRepository, ProductCommandRepository>();
            services.AddScoped<IProductQueryOutRepository, ProductQueryRepository>();
            services.AddScoped<IProductValidationService, ProductValidationApplication>();
        }
    }
}