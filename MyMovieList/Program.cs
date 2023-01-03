using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyMovieList.Controllers.data;
using MyMovieList.Controllers.data.enums;
using Npgsql;
using MyMovieList.Controllers.data;
using MyMovieList.Controllers.services;

var builder = WebApplication.CreateBuilder(args);
NpgsqlConnection.GlobalTypeMapper.MapEnum<genre.genres>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("name=ConnectionString:DefaultConnectionString"));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAccountsService, AccountsService>();
builder.Services.AddScoped<Imoviesservices, moviesservice>();
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
AppDbInitializer.Seed(app);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

