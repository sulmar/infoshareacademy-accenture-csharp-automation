
Console.WriteLine("Hello, World!");

Compressor compressor = new Compressor();
compressor.Name = "C-01";
compressor.Start();
compressor.Stop();

Mixer mixer = new Mixer();
mixer.Name = "M-03";
mixer.Start(Direction.Right);
mixer.Stop();


// Klasowa bazowa
class Machine
{
    public string Name { get; set; }

    protected bool isRunning;

    public Machine()
    {
        isRunning = false;
    }

    public void Start()
    {
        isRunning = true;
    }

    public void Stop()
    {
        isRunning = false;
    }

}

// Rozszerzamy istniejąca klasę

class Compressor : Machine // Dziedziczenie (inheritence) 
{
    public double Pressure { get; set; }

    public Compressor()
        : base()
    {
    }

    public new void Start()
    {
        base.Start();

        Pressure = 100;
        Console.WriteLine("Running Compressor");
        
    }

    
}

class Mixer : Machine
{
    public int RPM { get; set; }
    
    public Direction CurrentDirection {  get; set; }

    public Mixer()
        : base()
    {
        this.CurrentDirection = Direction.Left;
    }

    public void Start(Direction direction)
    {
        base.Start();

        this.CurrentDirection = direction;

        Console.WriteLine("Running Mixer");
    }
}

// Typ wyliczeniowy
enum Direction
{
    Right,
    Left,
}