using Microsoft.EntityFrameworkCore;
using MyBoilerplateDotNetCore6.Data.Repository;
using MyBoilerplateDotNetCore6.Data.SqlServer;
using MyBoilerplateDotNetCore6.ViewModel.Application;
using MyBoilerplateDotNetCore6.WebApi.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Get logger - To think further due to lack of support in logging in Program.cs
// Ref - Discussion about logging in Program.cs for .net core 6:
//       https://stackoverflow.com/questions/70634866/net-core-6-how-to-get-an-ilogger-instance-without-dependency-injection-in-pro
using var loggerFactory = LoggerFactory.Create(loggingBuilder => loggingBuilder
    .SetMinimumLevel(LogLevel.Trace)
    .AddConsole());
ILogger _logger = loggerFactory.CreateLogger<Program>();
_logger.LogInformation($"WebAPI started @ {DateTime.Now}");

ConfigurationManager configuration = builder.Configuration;
var config = configuration.Get<AppConfiguration>();
if (!StartupHelpers.ValidateConfiguration(_logger, config))
    Environment.Exit(1);

builder.Services.AddSingleton<AppConfiguration>();
builder.Services.AddDbContext<SqlServerDbContext>(options =>
    options.UseSqlServer(config.Database.ConnectionString_MainDb)
    );
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
