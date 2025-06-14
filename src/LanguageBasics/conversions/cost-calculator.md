# 🎯 Ćwiczenie: Koszt pracy urządzenia na podstawie zużycia energii

## 🎯 Cel  
Zrozumienie, jak posługiwać się konsolą i wykorzystywać funkcje konwersji (monitorowanie zużycia energii).

---

## 📝 Zadanie  
Maszyna przemysłowa zużywa energię elektryczną podczas pracy. Twoim zadaniem jest:

1. Zadeklarować zmienne:
   - czas pracy urządzenia (w godzinach),
   - zużycie energii w kWh,
   - cena energii za 1 kWh,
   - dopuszczalny koszt pracy.

2. Obliczyć całkowity koszt pracy maszyny.

3. Sprawdzić, czy koszt pracy przekracza ustalony próg (np. 300 zł).

4. Wypisać w konsoli raport w formacie:

```
⏱ Czas pracy: 12h
⚡ Zużycie: 34.5 kWh
💰 Koszt pracy: 345.00 zł
❗ Alarm: przekroczono dopuszczalny koszt!
```

---

## 🔧 Wskazówki

- Użyj operatorów arytmetycznych (`*`, `+`, `/`) do obliczeń.
- Wykorzystaj operator logiczny `>` do sprawdzenia, czy koszt przekracza limit.
- Skorzystaj z `Console.WriteLine(...)` do wypisania danych.
- Nazwy zmiennych stosuj w języku angielskim (np. `energyUsed`, `costLimit`).
- Nie twórz klas – pracujemy tylko na zmiennych.


## 🧑‍💻 Dodatkowe wymaganie

👉 Zamiast przypisywać wartości "na sztywno", zapytaj użytkownika o:
- liczbę godzin pracy (`Console.ReadLine()`)
- zużycie energii (`Console.ReadLine()`)
- cenę za 1 kWh (`Console.ReadLine()`)

Zastosuj konwersję z tekstu do liczby (np. `double.Parse(...)` lub `double.TryParse(...)`).
