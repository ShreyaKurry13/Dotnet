namespace DemoApp.Endpoints;

public class Greeting
{
    public static async Task Home(HttpResponse response)
    {
        await response.WriteAsync("Hello World!!!!");
    }

    public static async Task Ticks(HttpResponse response)
    {
        await response.WriteAsync(Environment.TickCount.ToString());
    }

    public static async Task Welcome(HttpResponse response)
    {
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>Welcome</title>
                </head>
                <body>
                    <h1>Welcome Visitor</h1>
                    <p>
                        <b>Current Time:</b> {DateTime.Now}
                    </p>

                    <form method="POST" action="Login">
                        <b>Name </b>
                        <input type="text" name="person">
                        <input type="submit" value="Sign in">
                    </form>
                </body>
            </html>
            """);
    }

    public static async Task Hello(HttpRequest request,HttpResponse response)
    {
        string user = request.Form["person"];
        int token = Random.Shared.Next(100000,1000000);
        await response.WriteAsync(
            $"""
                <html>
                <head>
                    <title>Welcome 2</title>
                </head>
                <body>
                    <h1>Hello {user}</h1>
                
                    <p>
                        <b>Your Secret Code : </b>{token}
                    </p>
                </body>
            </html>
            """
        );
    }


    public static async Task Bank(HttpResponse response)
    {
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>Welcome</title>
                </head>
                <body>
                    <h1>Welcome to Met Bank</h1>
                    
                    <p>
                        <b>Current Time:</b> {DateTime.Now}
                    </p>

                    <form method="POST" action="Interest">
                        <b>Principle </b>
                        <input type="text" name="principle">
                        <br>
                        <b>Rate </b>
                        <input type="text" name="rate">
                        <br>
                        <b>Period </b>
                        <input type="text" name="period">
                        <br>
                        <input type="submit" value="Get Interest">
                    </form>
                </body>
            </html>
            """);
    }


    public static async Task Interest(HttpRequest request,HttpResponse response)
    {
        double p = double.Parse(request.Form["principle"]);
        double r = double.Parse(request.Form["rate"]);
        double t = double.Parse(request.Form["period"]);
        double result = (p*r*t)/100;
        int token = Random.Shared.Next(100000,1000000);
        await response.WriteAsync(
            $"""
                <html>
                <head>
                    <title>Welcome 2</title>
                </head>
                <body>
                    <h1>Hello Customer</h1>
                    
                    <p>
                        <b>Your Secret Code : </b>{token}
                        <br>
                        <b>Your interest on your investment : </b>{result}
                    </p>
                </body>
            </html>
            """
        );
    }
}
