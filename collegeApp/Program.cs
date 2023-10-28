using collegeApp.MyLogging;
using Serilog;

/// <summary>
/// when this line get executed the logger added into the app
/// </summary>
var builder = WebApplication.CreateBuilder(args);


/*//to use just specific logger
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();*/

#region serilog setting
/*Log.Logger = new LoggerConfiguration().MinimumLevel.Information()
    .WriteTo.File("Log/log.txt",rollingInterval: RollingInterval.Day)
    .CreateLogger();

//to override the built in loggers
builder.Host.UseSerilog();
//built-in and sirilog loggers
builder.Logging.AddSerilog();

*/
#endregion
// Add services to the container.

//return error message for unsupported format and support xml format
builder.Services.AddControllers(options => options.ReturnHttpNotAcceptable = true).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//loosely coupled in Depedency Injection
builder.Services.AddScoped<IMyLogger, LogToFile>();
//builder.Services.AddScoped<IMyLogger, LogToDB>();
//builder.Services.AddScoped<IMyLogger, LogToServerMemory>();

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
