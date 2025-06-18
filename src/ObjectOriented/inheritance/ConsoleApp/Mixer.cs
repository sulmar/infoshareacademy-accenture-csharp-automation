
class Valve
{
    public string Name { get; set; }
    public bool IsOpened { get; set; }
    public bool CanClosed
    {
        get
        {
            return IsOpened;
        }
    }

    public bool HasFlowMeter { get; set; }
    public float OpeningDegree { get; set; }

    public Valve(string name)
    {
        this.Name = name;
    }

    public void Open()
    {
        IsOpened = true;
    }

    public void Close()
    {
        if (CanClosed)
        {
            IsOpened = false;
        }
    }
}

class Mixer : Machine
{
    public int RPM { get; set; }

    public Direction CurrentDirection { get; set; }

    private Valve valve;  // Kompozycja
   
    public Mixer(string name, Direction initDirection, Valve valve)
        : base(name)
    {
        this.CurrentDirection = initDirection;
        this.valve = valve;
    }

    public void Start(Direction direction)
    {
        base.Start();

        this.CurrentDirection = direction;

        valve.Open();

        Console.WriteLine($"Running Mixer {direction}");
    }

    public override void Stop()
    {
        if (valve.CanClosed)
        {
            valve.Close();

            base.Stop();
        }
    }
}
