using DemoApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IVisitCounter,PersonalCounter>();

var app = builder.Build();
app.MapRazorPages();
app.Run();
