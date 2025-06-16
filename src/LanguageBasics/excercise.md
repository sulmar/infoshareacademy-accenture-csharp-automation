# 🧪 Ćwiczenie – konfiguracja strefy pomiarowej
Celem tego ćwiczenia jest utrwalenie umiejętności definiowania zmiennych i stałych, a także poznanie ich zastosowania w kontekście przemysłowym.


---
## 📝 Opis:
Zakład przemysłowy posiada różne **strefy pomiarowe** (np. hala A, hala B). Każda strefa może posiadać czujniki temperatury. Niektóre dane są zmienne (np. bieżący pomiar), a inne są stałe (np. maksymalna dopuszczalna temperatura w danej strefie).

## 🧠 Twoje zadanie:
Zadeklaruj odpowiednie zmienne i stałą:
- `zoneName` – nazwa strefy (np. "Hala A")
- `currentTemperature` – zmierzona temperatura
- `isCoolingOn` – informacja, czy system chłodzenia jest aktywny
- `timestamp` – czas pomiaru
- `MaxTemperatureLimit` – stała określająca maksymalną dopuszczalną temperaturę (np. `75.0`)

Następnie wypisz w konsoli taką informację:

```bash
[2025-06-14 12:43:10] Strefa: Hala A | Temp: 78.2°C | Chłodzenie: TAK | Limit: 75°C
```
