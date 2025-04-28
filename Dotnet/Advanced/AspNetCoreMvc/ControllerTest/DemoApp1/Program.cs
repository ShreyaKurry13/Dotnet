using DemoApp.Services;
using DemoApp.Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IVisitCounter,PersonalCounter>();
builder.Services.AddTransient<SiteModel>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
