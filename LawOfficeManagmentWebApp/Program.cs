using LawOfficeManagmentWebApp.Data;
using LawOfficeManagmentWebApp.Repositories;
using LawOfficeManagmentWebApp.Repostories;
using LawOfficeManagmentWebApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LawOfficePortal")));


builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // mapping of the url .../Home/Index

app.Run();
