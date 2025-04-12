struct Box 
{
    public float Length{ get; set;}
    public float Breadth{ get; set;}
    public float Height{ get; set;}

    public double Volume()
    {
        return Length * Height * Breadth;
    }

    public override string ToString()
    {
        return $"{Length} x {Breadth} x {Height}";
    }
}