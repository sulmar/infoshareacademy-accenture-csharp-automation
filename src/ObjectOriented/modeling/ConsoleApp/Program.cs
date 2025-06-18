
Console.WriteLine("Hello, World!");

// Utworzenie instancji klasy czyli utworzenie obiektu
TemperatureSensor sensor1 = new TemperatureSensor();  // Obiekt klasy TemperatureSensor
sensor1.SensorId = "T-01";
sensor1.Temperature = 89.5;
sensor1.Report();


sensor1.Enable();

sensor1.Temperature = 10;

double? currentTemperature = sensor1.Temperature;

sensor1.Report();

sensor1.Disable();

var sensor2 = new TemperatureSensor(); // Kolejny obiekt klasy TemperatureSensor
sensor2.SensorId = "T-02";
sensor2.Enable();
sensor2.Temperature = 71.5;

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
    public string SensorId { get; set; } // Właściwość (Property)

    private bool isActive;


    private double? temperature;  // Pole prywatne (Private Field) - back field 
    public double? Temperature // Właściwość (Property)
    {
        set // setter (ustawiacz)
        {
            if (isActive)
            {
                this.temperature = value; // value - zawiera przypisaną wartość
            }
        }
        get // getter (pobieracz)
        {
            if (isActive)
            {
                return this.temperature;
            }
            else
                return null;
        }
    }


    /*    
    public void SetTemperature(double temperature) // temperature - lokalna zmienna (parametr metody)
    {
        if (isActive)
        {
            this.temperature = temperature; // this - wskazuje obiekt
        }
    }

    public double? GetTemperature()
    {
        if (isActive)
        {
            return this.temperature;
        }
        else
            return null;
    }

    */

    public void Enable()
    {
        isActive = true;

        // Thread.Sleep(5000);     - programowanie synchroniczne - wszystko się dzieje w 1 wątku
        // await Task.Delay(5000); - programowanie asynchroniczne - może być kilka wątków 

        Console.WriteLine($"{SensorId} activated.");
    }

    public void Disable()
    {
        isActive = false;

        Console.WriteLine($"{SensorId} deactived.");
    }



    // Metoda
    public void Report()
    {
        Console.WriteLine($"{SensorId} temperature: {temperature}°C active: {isActive}");
    }
}
