
Console.WriteLine("Hello, World!");

Machine machine = new Machine();

while (true)
{

    Console.Write("Podaj obciążenie: ");

    try
    {
        double load = double.Parse(Console.ReadLine());

        machine.Load(load);
    }
    catch (MachineOverloadException e)
    {
        Console.WriteLine($"Błąd urządzenia: {e.Message}");
    }

}


class Machine
{
    public void Load(double load)
    {
        if (load > 100)
        {
            throw new MachineOverloadException($"Obciążenie {load} przekracza dopuszczalny limit!");
        }

        Console.WriteLine($"Obciążenie {load}");
    }
}


// Definicja własnej klasy Exception
class MachineOverloadException : ApplicationException
{
    public MachineOverloadException(string message) : base(message)
    {

    }
}