Console.WriteLine("Hello, World!");

Compressor compressor = new OilCompressor("C-01");

Mixer mixer = new Mixer("M-03", Direction.Left);
mixer.Start(Direction.Right);
mixer.Stop();

Machine machine = compressor;
machine.Start();
machine.Stop();



// Klasowa bazowa
 abstract class Machine
{
    public string Name { get; set; }

    protected bool isRunning;

    public Machine(string name)
    {
        this.Name = name;

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

// Klasa abstrakcyjna - nie można utworzyć instancji tej klasy
abstract class Compressor : Machine // Dziedziczenie (inheritence) 
{
    public double Pressure { get; set; }

    public Compressor(string name)
        : base(name)
    {
    }

    public new void Start()
    {
        base.Start();

        Pressure = 100;
        Console.WriteLine("Running Compressor");

    }
}

// Hierarchia klas OilCompressor -> Compressor -> Machine
class OilCompressor : Compressor
{
    public double OilLevel { get; set; }

    public OilCompressor(string name) : base(name)
    {
        
    }

    public new void Start()
    {
        base.Start();

        Console.WriteLine("Running Oil Compressor");
    }
}

// Hierarchia klas AirCompressor -> Compressor -> Machine
class AirCompressor : Compressor
{
    public AirCompressor(string name) : base(name)
    {
        
    }

    public new void Start()
    {
        base.Start();
        
        Console.WriteLine("Running Air Compressor");
    }
}

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

        Console.WriteLine("Running Mixer");
    }
}

// Typ wyliczeniowy
enum Direction
{
    Right,
    Left,
}