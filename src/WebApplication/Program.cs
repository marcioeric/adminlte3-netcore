using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenTelemetry.Metrics;
using Serilog;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews()
#if DEBUG
    .AddRazorRuntimeCompilation();
#elif !DEBUG
    ;
#endif

#region Serilog Configuration

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

builder.Services.AddSerilog();

#endregion

#region Metrics Configuration

builder.Services.AddOpenTelemetry().WithMetrics(b => b.AddAspNetCoreInstrumentation().AddPrometheusExporter());

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseSerilogRequestLogging();

app.UseOpenTelemetryPrometheusScrapingEndpoint(context => context.Request.Path == "/internal/metrics");

app.Run();