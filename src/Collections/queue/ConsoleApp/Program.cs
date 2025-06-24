

Queue<string> alarmQueue = new Queue<string>();

alarmQueue.Enqueue("Urządzenie T-01 przekroczyło poziom 85 stopni C");

alarmQueue.Enqueue("Spadek ciśnienia w komorze spalania");

alarmQueue.Enqueue("Przeciążenie maszyny M-05");


while(alarmQueue.Count > 0)
{
    string alarm = alarmQueue.Dequeue(); // Pobierz i usuń

    Console.WriteLine($"Przetwarzanie alarmu: {alarm}");
}


Console.WriteLine("Koniec alarmów.");