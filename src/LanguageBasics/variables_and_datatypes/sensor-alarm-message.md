# Ćwiczenie: Wiadomość alarmowa z czujnika

## 🎯 Cel
Zrozumienie, czym są zmienne, pętlę i wyrażenia warunkowe i jak przetwarzać dane w oparciu o sytuację z życia wziętą (IoT – alarm z czujnika).

## 📝 Zadanie

Czujnik przemysłowy wysyła wiadomość e-mail do operatora zakładu w przypadku przekroczenia temperatury. Twoim zadaniem jest:


1. Zasymuluj czujnik temperatury, który wysyła 10 odczytów
2. W przypadku prekroczenia dopuszczalnej wartości temperatury np. `80 °C` powinna zostać wygenerowana treść wiadomości e-mail.
4. Zadeklarować zmienne z odpowiednimi nazwami (j. ang.) i wartościami (bez klas!).
5. Wypisać w konsoli wiadomość w formacie:

```
Do: operator@zaklad.pl
Temat: Alarm z czujnika
Treść: Sensor T-01 zmierzył 87.2°C o 2025-06-14 12:31. Status: AKTYWNY
```

## 🔧 Wskazówki

- Nie sugerujemy typów — sam zdecyduj, jakiego typu dane są odpowiednie.
- Możesz skorzystać z `Console.WriteLine(...)`, aby wypisać treść wiadomości.
- Pomyśl: co powinien zawierać temat, treść i kto jest odbiorcą?

## 🔧 Dla chętnych
- Symulowanie czujnika, która odczytuje dane 1 sekundę bez końca. Wskazówka: Użyj klasy `Random.Shared`

Powodzenia!
