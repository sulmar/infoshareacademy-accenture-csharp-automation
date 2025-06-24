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


// Wyszukaj wszystkie telefony Xiaomi
List<Phone> filteredByNamePhones = new List<Phone>();

foreach (Phone p in phoneList)
{
    if (p.Model.StartsWith("Xiaomi"))
    {
        filteredByNamePhones.Add(p);
    }
}

// LINQ (Language Integrated Query)

// Wyrażenie lambda (skrócony zapis)
// p => p > 100

var filteredByNamePhonesWithLinq = phoneList
    // .Select(p => p)                                              // odpowiednik SELECT *    
    .Select(p => new { p.Model, p.BatteryLevel, p.IsRunning }) // odpowiednik  SELECT Model, BatteryLevel, IsRunning
    .Where(p => p.Model.StartsWith("Xiaomi"))   // filtrowanie
    .OrderBy(p => p.BatteryLevel)                    // sortowanie
    .ToList();


var query = from p in phoneList
            where p.Model.StartsWith("Xiaomi")
            orderby p.Model
            select new { p.Model, p.BatteryLevel, p.IsRunning };


List<Sensor>? sensors = new List<Sensor> { 
    new Sensor("S01"), 
    new Sensor("SO2"), 
    new Sensor( "SO3" )
};

List<Sensor>? damagedSenors = new List<Sensor> {
    new Sensor("SO2"),
    new Sensor( "SO3" ),
    new Sensor( "SO4" )
};

var measures = new List<Measure>
{
    new Measure("S01"),
    new Measure("SO3")
};

var query2 = sensors.Join(measures,
    s => s.Name,            // lewy klucz
    m => m.SensorName,      // prawy klucz
    (s, m) => new { Sensor = s, Measure = m });

var activeSensors = sensors.Except(damagedSenors).ToList();
   

// Linq używa wyrażeń Lambda do definicji zapytań


// SQL:
// SELECT Model, BatteryLevel FROM Phones
// WHERE Model LIKE 'Xiaomi%'
// ORDER BY batteryLevel

Console.WriteLine("Znalezione telefony: ");

foreach (var phone in filteredByNamePhonesWithLinq)
{
    Console.WriteLine(phone.Model);
}


Console.WriteLine();

class Sensor
{
    public string Name { get; set; }

    public Sensor(string name)
    {
        Name = name;
    }
}


class Measure
{
    public string SensorName { get; set; }

    public Measure(string sensorName)
    {
        SensorName = sensorName;
    }

    public float Value { get; set; }
}

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