Console.WriteLine("Hello, World!");

double temperature = 123.4;
double threshold = 120;

bool isOverheated = temperature > threshold;

// ## Operatory arytmetyczne

if (isOverheated)
{
    Console.WriteLine("Alarm: Została przekroczona dopuszczalna temperatura!");

    temperature = temperature - 10; // Dekrementacja o 10 

    temperature -= 10;  // Dekrementacja o 10 (zapis skrócony)

    temperature--; // Dekrementacja o 1

    temperature = temperature + 10; // Inkrementacja o 10

    temperature += 10; // Inkrementacja o 10 (zapis skrócony)

    temperature++;  // Inkrementacja o 1
}
else
{
    Console.WriteLine("Temperatura w normie.");
}


Console.WriteLine($"Aktualna temperatura: {temperature}°C");

// ## Wyrażenia logiczne

double humidity = 23.01;

// iloczyn logiczny AND 
if (isOverheated && humidity > 20)
{
    Console.WriteLine("Została przekroczona dopuszczalna temperatura i ciśnienie.");
}

// suma logiczna OR 
if (isOverheated || humidity > 20)
{
    Console.WriteLine("Została przekroczona dopuszczalna temperatura lub ciśnienie.");
}

// negacja 
if(!isOverheated)
{
    Console.WriteLine("Temperatura w normie.");
}
