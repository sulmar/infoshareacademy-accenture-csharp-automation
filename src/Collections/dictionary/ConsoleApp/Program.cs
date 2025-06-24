
Dictionary<string, Sensor> sensors = new Dictionary<string, Sensor>();
sensors["T-01"] = new Sensor("Czujnik temperatury w hali 1");
sensors["P-02"] = new Sensor("Czujnik ciśnienia w zbiorniku A");
sensors["M-03"] = new Sensor("Waga w magazynie M1");

sensors.Add("X-01", new Sensor("Czujnik położenia"));

Sensor selectedSensor = sensors["M-03"];

Console.WriteLine(selectedSensor.Name);


var sensorList = sensors.Select(s => s.Value).ToList();





class Sensor
{
    public string Name { get; set; }
    public float Value { get; set; }

    public Sensor(string name)
    {
        this.Name = name;
    }
}