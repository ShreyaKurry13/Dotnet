using DemoApp.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Home",Greeting.Home);
app.MapGet("/Count",Greeting.Ticks);
app.MapGet("/Welcome",Greeting.Welcome);
app.MapPost("/Login",Greeting.Hello);
app.MapGet("/Bank",Greeting.Bank);
app.MapPost("/Interest",Greeting.Interest);
app.Run();
