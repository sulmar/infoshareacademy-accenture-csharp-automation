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

    // virtual - włącza mechanizm poliformizmu (wielopostaciowość)
    // poliformizm - oznacza, że metoda, która należy wywołać jest określone w czasie działania aplikacji
    public virtual void Start()
    {
        isRunning = true;
    }

    public virtual void Stop()
    {
        isRunning = false;
    }

}
