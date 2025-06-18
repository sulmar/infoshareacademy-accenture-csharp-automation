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
