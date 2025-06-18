class Mixer : Machine
{
    public int RPM { get; set; }

    public Direction CurrentDirection { get; set; }


    public string ValveName { get; set; }
    public bool IsValveOpened { get; set; }
    public bool CanValveClosed { get; set; }
    public bool HasFlowMeter { get; set; }
    public float OpeningDegree { get; set; }

    public void Open()
    {
        IsValveOpened = true;
    }

    public void Close()
    {
        if (CanValveClosed)
        {
            IsValveOpened = false;
        }
    }

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
