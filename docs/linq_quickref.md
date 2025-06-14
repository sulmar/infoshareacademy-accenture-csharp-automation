# 🧠 LINQ Cheat Sheet – dla C#

Najczęściej używane operacje LINQ na kolekcjach w C# (List<T>, tablice, itp.).

## 📋 Select – projekcja
```csharp
var nazwy = produkty.Select(p => p.Nazwa);
```

## 🔍 Where – filtrowanie
```csharp
var drogie = produkty.Where(p => p.Cena > 100);
```

## 🔢 OrderBy / ThenBy – sortowanie
```csharp
var posortowane = produkty
    .OrderBy(p => p.Kategoria)
    .ThenByDescending(p => p.Cena);
```

## 🧮 Count, Any, All – operacje logiczne
```csharp
int liczbaAktywnych = czujniki.Count(c => c.Aktywny);
bool wszystkieOK = czujniki.All(c => c.Status == "OK");
bool jakikolwiekAwaria = czujniki.Any(c => c.Status == "Błąd");
```

## 🔄 GroupBy – grupowanie
```csharp
var grupy = produkty.GroupBy(p => p.Kategoria);
foreach (var grupa in grupy)
{
    Console.WriteLine($"Kategoria: {grupa.Key} ({grupa.Count()})");
}
```

## 🔂 First / FirstOrDefault
```csharp
var pierwszy = produkty.First(p => p.Cena > 100);
var domyslny = produkty.FirstOrDefault(p => p.Kategoria == "Brak");
```

## 🔗 Łączenie operacji
```csharp
var raport = produkty
    .Where(p => p.Aktywny)
    .OrderBy(p => p.Nazwa)
    .Select(p => $"{p.Nazwa}: {p.Cena} zł");
```

## 📦 Praca na listach

Zamiana tablicy na listę i odwrotnie:
```csharp
var lista = array.ToList();
var tablica = lista.ToArray();
```

---
