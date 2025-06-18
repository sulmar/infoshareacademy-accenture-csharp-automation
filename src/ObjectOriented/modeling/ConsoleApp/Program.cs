
Console.WriteLine("Hello, World!");

// Utworzenie instancji klasy czyli utworzenie obiektu
TemperatureSensor sensor1 = new TemperatureSensor();  // Obiekt klasy TemperatureSensor
sensor1.sensorId = "T-01";
sensor1.isActive = true;
sensor1.temperature = 89.5;

sensor1.Report();

var sensor2 = new TemperatureSensor(); // Kolejny obiekt klasy TemperatureSensor
sensor2.sensorId = "T-02";
sensor2.isActive = true;
sensor2.temperature = 71.5;

sensor2.Report();

double ConvertToFarenhait(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;

    return fahrenheit;
}


// Klasa
class TemperatureSensor
{
    // pola (cechy)
    public string sensorId;
    public bool isActive;
    public double temperature;

    // Metoda
    public void Report()
    {
        Console.WriteLine($"{sensorId} temperature: {temperature}°C active: {isActive}");
    }
}
