using RobinMoses;
using RobinMoses.Data;
using RobinMoses.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<WebDbContext>();

builder.Services.AddTransient<IWebSiteRepo, WebSiteRepo>();


builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<WebDbContext>().AddDefaultTokenProviders();

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
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WebDbContext>();
    //  Use context
    //SeedData.Seed(dbContext, scope.ServiceProvider);
}

app.Run();
