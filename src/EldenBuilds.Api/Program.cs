using EldenBuilds.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServices(builder.Configuration);
builder.Services.AddControllers();

var app = builder.Build();

app.UseApplicationPipeline();
await app.SeedDatabaseAsync();

app.Run();
