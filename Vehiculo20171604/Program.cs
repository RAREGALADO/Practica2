using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Vehiculo20171604.Data;
using Vehiculo20171604.Data.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSqlite<Vehiculo20171604DbContext>("Data Source=.//Data//Context//localDB.sqlite");
builder.Services.AddScoped<Vehiculo20171604DbContext,Vehiculo20171604DbContext>();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Vehiculo20171604DbContext>();
    if (db.Database.EnsureCreated())
    {
        
    }
}

app.Run();
