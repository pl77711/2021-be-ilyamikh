using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ThemesApi.Data;
using ThemesApi.Data.Repositories;
using ThemesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ThemesApi
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ThemeContext")));

            services.AddScoped<ApplicationDataInitializer>();
            services.AddScoped<IChapterRepository, ChapterRepository>();
            services.AddScoped<IPrioriteitRepository, PriorityRepository>();
            services.AddScoped<IThemeRepository, ThemeRepository>();

            // Register the Swagger services
            services.AddOpenApiDocument(c =>
            {
                c.DocumentName = "apidocs";
                c.Title = "Theme API";
                c.Version = "v1";
                c.Description = "The Theme API documentation description.";
            }); 

            services.AddCors(options => options.AddPolicy("AllowAllOrigins", builder => builder.AllowAnyOrigin()));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDataInitializer themeDataInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            themeDataInitializer.InitializeData();
            
        }
    }
}
