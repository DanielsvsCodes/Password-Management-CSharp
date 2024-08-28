using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Configure logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

// Add services to the container
builder.Services.AddControllers();

// Configure MongoDB client using connection string from appsettings.json
string mongoConnectionString = builder.Configuration.GetConnectionString("MongoDb") 
                               ?? "mongodb://root:example@localhost:27017/";

builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(mongoConnectionString));

// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Map test controller
app.MapControllers();

// Simple test endpoint
app.MapGet("/test", () => "Hello from Notification Service!");

// Run the app
app.Run();
