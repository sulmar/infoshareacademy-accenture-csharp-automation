
// Pętla for - wykona blok określoną ilość razy
for (int copy = 0; copy < 5; copy++)
{
    Console.WriteLine($"Hello, Marcin! Copy #{copy + 1}");
}


string selectedSensor = "T-01";

// Tablica
string[] sensors = new string[3];

sensors = [ "T-01", "T-02", "T-03" ];

// Pętla foreach - wykona blok dla każdego elementu
foreach (string sensor in sensors)
{
    Console.WriteLine($"Czujnik {sensor}");
}

// Pętla while - wykonuj coś dopóki jest spełniony warunek

CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)); // Wysyła żądanie anulowania po 10 sek.

CancellationToken cancellationToken = cts.Token;

while(!cancellationToken.IsCancellationRequested)
{
    Console.WriteLine("Odczyt pomiaru...");

    Thread.Sleep(1000); // opóźnienie 1 sek.
}

string input;
int attempts = 0;

do
{
    Console.WriteLine("Podaj kod dostępu:");
    input = Console.ReadLine();
    attempts++;
}
while (input != "1234" && attempts < 3);
{
    if (input == "1234")
        Console.WriteLine("Zalogowany");
    else
        Console.WriteLine("Przekroczona ilość prób");
}
