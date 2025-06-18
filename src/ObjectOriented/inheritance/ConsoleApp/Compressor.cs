// Rozszerzamy istniejąca klasę

// Klasa abstrakcyjna - nie można utworzyć instancji tej klasy
abstract class Compressor : Machine // Dziedziczenie (inheritence) 
{
    public double Pressure { get; set; }

    public Compressor(string name)
        : base(name)
    {
    }

    // override - przysłanianie
    public override void Start()
    {
        base.Start();

        Pressure = 100;
        Console.WriteLine("Running Compressor");

    }
}
