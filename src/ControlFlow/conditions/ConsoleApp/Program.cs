
Console.WriteLine("Hello, World!");

double pressure = 101.5;

string message = "";

// wiele warunków
if (pressure > 120)
{
    message = "Zbyt wysokie ciśnienie";
}
else if (pressure < 90)
{
    message = "Zbyt niskie ciśnienie";
}
else
{
    message = "Ciśnienie w normie.";
}


// Match Patterns (Wzorce dopasowania)
string message2 = pressure switch
{
    > 120 => "Zbyt wysokie ciśnienie",
    < 90 => "Zbyt niskie ciśnienie",
    _ => "Ciśnienie w normie."
};

Console.WriteLine(message2);


string sensorType = "z";

// snippets:
// cw - Console.WriteLine

/*
if (sensorType == "temperature")
    Console.WriteLine("Czujnik temperatury");
else if (sensorType == "pressure")
    Console.WriteLine("Czujnik ciśnienia");
else
    Console.WriteLine("Nieznany typ czujnika");
*/

switch (sensorType)
{
    case "temperature": Console.WriteLine("Czujnik temperatury"); break;
    case "pressure": Console.WriteLine("Czujnik ciśnienia"); break;
    default: Console.WriteLine("Nieznany typ czujnika"); break;
}

double humidity = 125.01;

// string message3 = humidity > 120 ? "tak" : "nie";   // zła praktyka: Magic Number

const double maxHumidity = 120;

string message3 = humidity > maxHumidity ? "tak" : "nie";   // dobra praktyka: Korzystamy ze stałych