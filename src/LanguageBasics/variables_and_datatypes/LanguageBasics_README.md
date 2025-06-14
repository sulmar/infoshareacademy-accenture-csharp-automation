# 🔹 LanguageBasics – Zmienne i typy

### 🧠 Wprowadzenie – czym jest zmienna?

> Zmienna to nazwany obszar pamięci, który przechowuje określony typ danych. Każda zmienna musi być zadeklarowana z typem.

---

### 📦 Typy danych podstawowych w kontekście IoT:

| Typ        | Opis                        | Przykład       | Zastosowanie w IoT     |
| ---------- | --------------------------- | -------------- | ---------------------- |
| `string`   | Tekst                       | `"T-01"`       | Identyfikator czujnika |
| `double`   | Liczba zmiennoprzecinkowa   | `21.7`         | Temperatura, ciśnienie |
| `float`    | Mniej precyzyjny niż double | `21.7f`        | Pozycjonowanie         |
| `bool`     | Wartość logiczna            | `true`         | Czy czujnik aktywny    |
| `DateTime` | Data i czas                 | `DateTime.Now` | Czas pomiaru           |

---

### 🧪 Przykład – zadeklaruj dane pomiaru

```csharp
string sensorId = "T-01";
double temperature = 23.8;
bool isActive = true;
DateTime timestamp = DateTime.Now;

Console.WriteLine($"[{timestamp}] Sensor {sensorId}: {temperature}°C (active: {isActive})");
```
