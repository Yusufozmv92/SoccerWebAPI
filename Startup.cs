using Microsoft.EntityFrameworkCore;
using SoccerWebAPI.Contexts;

namespace SoccerWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration["ConnectionStrings:TeamsDBConnectionString"];
            builder.Services.AddDbContext<TeamsContext>(o => o.UseSqlServer(connectionString));
            builder.Services.AddControllers();
        }
        public static void Configure(WebApplication app)
        {
            //Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

        }
    }
}
