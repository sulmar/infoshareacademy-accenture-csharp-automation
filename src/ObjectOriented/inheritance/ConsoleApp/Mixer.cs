
class Mixer : Machine
{
    public int RPM { get; set; }

    public Direction CurrentDirection { get; set; }

    private InputValve inputValve;  // pola Kompozycja
    private OutputValve outputValve; // pola
   
    public Mixer(string name, Direction initDirection, InputValve inputValve, OutputValve outputValve)
        : base(name)
    {
        this.CurrentDirection = initDirection;
        this.inputValve = inputValve;
        this.outputValve = outputValve;
    }

    public void ReplaceInputValve(InputValve valve)
    {
        this.inputValve = valve;
    }

    public void Start(Direction direction)
    {
        base.Start();

        this.CurrentDirection = direction;

        inputValve.Open();
        outputValve.Close();

        Console.WriteLine($"Running Mixer {direction}");
    }

    public override void Stop()
    {
        if (inputValve.CanClosed)
        {
            inputValve.Close();
            outputValve.Open();

            base.Stop();
        }
    }
}
