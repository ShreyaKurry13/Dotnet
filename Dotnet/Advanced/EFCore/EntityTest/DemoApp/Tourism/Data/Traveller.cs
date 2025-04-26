namespace DemoApp.Tourism.Data;

public class Traveller
{
    public string Id{get; set;}

    public int Rating{ get; set;}

    public List<Trip> Tours{get; set; } = [];
}
