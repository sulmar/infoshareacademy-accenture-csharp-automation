class Mixer : Machine
{
    public int RPM { get; set; }

    public Direction CurrentDirection { get; set; }

    public Mixer(string name, Direction initDirection)
        : base(name)
    {
        this.CurrentDirection = initDirection;
    }

    public void Start(Direction direction)
    {
        base.Start();

        this.CurrentDirection = direction;

        Console.WriteLine($"Running Mixer {direction}");
    }
}
