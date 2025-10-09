using Models;
using Serilog;

namespace Backend;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSerilog((services, lc) => lc
            .WriteTo.Console());
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        var user = new User("Udo");

        await app.RunAsync();
    }
}