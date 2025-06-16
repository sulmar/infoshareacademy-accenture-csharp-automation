
// # Zmienne

// Utworzenie zmiennej typu tekst
string name = "Marcin";
string Name = "John"; // w C# wielkość liter ma znaczenie!

// zła praktyka
// Console.WriteLine("Hello, " + name + "!");

// dobra praktyka 
Console.WriteLine($"Hello, {name}!"); // $ - Interpolacja

// Notacje używane w C#:

// Camel Case - nazwy zmiennych
string sensorId = "T-01";

// Pascal Case - nazwy metod, klas, właściwości, stałych
Console.WriteLine();

// Typ liczba zmiennoprzecinkowa (podwójnej precyzji)
double temperature = 23.8;

// Typ liczba zmiennoprzecinkowa (pojedyńczej precyzji)
float latitude = 51.01f;

// Typ liczba całkowita (32-bitowa) -2^31 + 2^31
int counter = 10;

// Typ liczba całkowita (8-bitowa 0..255)
byte dailyCounter = 255;

// Typ logiczny (boolowski)
bool isActive = true;

// Typ data + czas
DateTime timestamp = DateTime.Now;

// Typ interwał czasu
TimeSpan duration = TimeSpan.FromSeconds(30);

// ## Rzutowania (konwersja typów)

counter = (int) latitude; // ucina część ułamkową

// Sprawdzanie przepełnienia (przekroczenia limitu danego typu)
//checked
//{
//    dailyCounter++;

//    dailyCounter++;

//    dailyCounter++;
//}

Console.WriteLine(dailyCounter);

counter = dailyCounter; // niejawne rzutowanie

dailyCounter = (byte) counter;  // jawne rzutowane (casting) 

temperature = double.Parse("21"); // konwersja typu z tekstu na liczbę


// ## Wartości nullable (wartość pusta, nieokreślona)

double? currentTemperature = null;
Nullable<DateTime> stopDate = null;
string? secondName = null;


// ## var - silnie typowanie - typ jest wnioskowany na podstawie przypisanej wartości
var area = "sector C";

var weight = 100;

var person = new { FirstName = "John", LastName = "Smith" };

// Stałe (constants)
const float PI = 3.14f;

const int speedOfLight = 300_000; // Liczby mogą być odseparowane za pomocą podkreślenia (nie zmienia wartości)


// Przypisanie konretnej daty
DateTime startMeasure = DateTime.Parse("2025-06-16 23:00");

Console.WriteLine(startMeasure);





