using SoccerWebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Startup.ConfigureServices(builder);
//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

Startup.Configure(app);
app.Run();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/