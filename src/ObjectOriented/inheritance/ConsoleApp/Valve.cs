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
