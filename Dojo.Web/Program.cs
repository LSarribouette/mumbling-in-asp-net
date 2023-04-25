using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Services;
using Dojo.Infrastructure;
using Dojo.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureServices(builder.Configuration.GetConnectionString("DojoWebContext"));
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISamouraiRepository, SamouraiRepository>();
builder.Services.AddTransient<IArmeRepository, ArmeRepository>();
//builder.Services.AddTransient<IRepository, BaseRepository>();
builder.Services.AddTransient<SamouraiService>();
builder.Services.AddTransient<ArmeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
