using Dojo.Domain.Interfaces.Repositories;
using Dojo.Domain.Services;
using Dojo.Infrastructure;
using Dojo.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfrastructureServices(builder.Configuration.GetConnectionString("DojoWebContext"));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DojoContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISamouraiRepository, SamouraiRepository>();
builder.Services.AddTransient<IArmeRepository, ArmeRepository>();
builder.Services.AddTransient<IArtMartialRepository, ArtMartialRepository>();
//builder.Services.AddTransient<IRepository, BaseRepository>();
builder.Services.AddTransient<SamouraiService>();
builder.Services.AddTransient<ArmeService>();
builder.Services.AddTransient<ArtMartialService>();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
