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
