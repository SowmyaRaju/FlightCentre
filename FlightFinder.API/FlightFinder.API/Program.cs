using FlightFinder.API.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Dependency Injection
builder.Services.RegisterServices();

var app = builder.Build();

app.ConfigureSwagger();

app.UseAuthorization();

app.MapControllers();

app.Run();
