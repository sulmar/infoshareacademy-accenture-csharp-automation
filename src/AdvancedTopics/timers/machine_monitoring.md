# 🕒 Monitorowanie stanu maszyny z wykorzystaniem Timerów

W tym rozdziale nauczysz się, jak wykorzystać klasę `System.Timers.Timer` do reagowania na zmiany stanu maszyny na podstawie danych telemetrycznych.

---

## 🎯 Kontekst przemysłowy

W zakładzie produkcyjnym monitorujemy **uruchomienie maszyny**. Maszyna nie powinna być uznawana za uruchomioną, jeśli prędkość nie przekracza progu przez co najmniej **10 sekund**.

---

## 📁 Format danych

Maszyny zapisują dane telemetryczne w plikach `.csv` i `.xml`:

### ✅ Przykład `machine-01.csv`
```
timestamp,speed1,speed2
2025-06-14T08:00:01,0.0,0.0
2025-06-14T08:00:02,0.1,0.0
2025-06-14T08:00:11,1.2,0.9
```

### ✅ Przykład `machine-01.xml`
```xml
<MachineReadings>
  <Reading timestamp="2025-06-14T08:00:01" speed1="0.0" speed2="0.0" />
  <Reading timestamp="2025-06-14T08:00:11" speed1="1.2" speed2="0.9" />
</MachineReadings>
```

---

## 💡 Zadanie

Napisz program, który:

1. Wczyta dane telemetryczne z pliku CSV lub XML.
2. Obliczy, kiedy maszyna **faktycznie rozpoczęła pracę** (obie prędkości > 0 przez co najmniej 10 sekund).
3. Wypisze w konsoli:
   ```
   Maszyna rozpoczęła pracę o 08:00:11
   ```
4. Zapisze wynik do pliku `machine-01-status.txt`.

---

## 🔧 Narzędzia

- `System.Timers.Timer`
- `System.IO.File.ReadAllLines(...)`
- `System.Xml.Linq.XDocument` (dla XML)
- `DateTime`, `TimeSpan`

---

## 🧠 Pytania kontrolne

- Co się stanie, jeśli prędkość spadnie poniżej progu po 9 sekundach?
- Jak można dodać tolerancję błędu czujnika?

