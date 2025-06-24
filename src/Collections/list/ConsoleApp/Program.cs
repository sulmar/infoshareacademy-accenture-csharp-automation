using ConsoleApp;

List<Phone> phoneList = new List<Phone>(); // List to store Phone objects
string[] data = File.ReadAllLines(path: "Phones.txt");

foreach (string line in data.Skip(1)) // Skip the first line (header) || Take all lines except the first one
{
    Console.WriteLine(value: line);
    string[] fields = line.Split(separator: ',');
    int batteryLevel = int.Parse(fields[1]);
    Phone newPhone = new Phone(fields[0], new Battery(batteryLevel));
    phoneList.Add(newPhone); // Add new Phone object to the list
}

Console.WriteLine("\nList of loaded phones:"); // Display the list of phones
foreach (Phone listedPhone in phoneList)
{
    Console.WriteLine($"- {listedPhone.Model}");
}

Console.WriteLine();


class ProductionLine
{
    private List<Machine> machines = new List<Machine>();

    public void Add(Machine machine)
    {
        machines.Add(machine);
    }

    public string Name { get; set; }

    public ProductionLine(string name)
    {
        this.Name = name;
    }
}

abstract class Machine
{
    public abstract string Name { get; set; }

    protected Machine(string name)
    {
        Name = name;
    }

}