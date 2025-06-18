class Boxing : Machine
{
    public Boxing(string name): base(name)
    {
        
    }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Switch Relay On");
    }

}