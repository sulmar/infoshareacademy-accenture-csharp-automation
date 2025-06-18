# 🧪 Ćwiczenie – tokarka

---
## 📝 Opis:
Zakład przemysłowy posiada maszynę typu **tokarka**, służącą do obróbki elementów metalowych. Tokarka pracuje z określoną liczbą obrotów na minutę (RPM) i może być sterowana za pomocą aplikacji.


## 🧠 Twoje zadanie:

Zaprojektuj klasę `Lathe` (tokarka), która zawiera:

### Właściwości
- `Name`, np "Tokarka-9"
- `Rpm` – obroty na minutę
- `IsRunning` (jeśli RPM są większe od 0 to oznacza, że tokarka jest uruchomiona, w przeciwnym razie zatrzymana.

### Metody 

- Wypisz stan tokarki jak poniżej:

```bash
[2025-06-18 12:43:10] Machine: Tokarka-9 | Status: IsRunning | RPM: 900 | 
```

```bash
[2025-06-18 12:43:10] Machine: Tokarka-9 | Status: Idle | RPM: 0 | 
```

- Dodaj metodę, która oblicza czas toczenia w sekundach dla zadanej długości `length` na podst. wzoru"
```bash
czas = długość / (RPM × 0.1)
```

- Dodaj metodę, która zwiększa lub zmniejsza obroty o podaną wartość `delta`

- Dodaj metodę, która zwiększa obroty tokarki w krokach co 100 RPM, aż do osiągnięcia wartości docelowej `targetRpm`.

Podczas każdego kroku niech wypisuje aktualne obroty do konsoli.

```bash
[2025-06-18 12:43:10] Machine: Tokarka-9 | Status: IsRunning | RPM: 100 | 
[2025-06-18 12:43:12] Machine: Tokarka-9 | Status: IsRunning | RPM: 200 | 
...  
Current RPM: 1000
[2025-06-18 12:43:12] Machine: Tokarka-9 | Status: IsRunning | RPM: 1000 | 
```

## Czas: 30 min.
