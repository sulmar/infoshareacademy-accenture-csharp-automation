# 🧠 SQL Cheat Sheet – dla C#

Podstawowe zapytania SQL używane w integracji z C# i bazami danych MES.

## 🗂️ Podstawowe zapytania

### 📋 SELECT – pobieranie danych
```sql
SELECT * FROM Produkty;

SELECT Name, Price FROM Produkty
WHERE Price > 100
ORDER BY Price DESC;
```

### 🔍 WHERE – filtrowanie
```sql
SELECT * FROM Czujniki
WHERE Status = 'ACTIVE' AND Typ = 'Temperatura';
```

### 🔢 ORDER BY – sortowanie
```sql
SELECT * FROM Produkty
ORDER BY Nazwa ASC, Cena DESC;
```

### 🔁 JOIN – łączenie tabel
```sql
SELECT o.Id, o.DataZamowienia, k.Nazwa
FROM Zamowienia o
JOIN Klienci k ON o.KlientId = k.Id;
```

## ✏️ Wstawianie i aktualizacja

### ➕ INSERT
```sql
INSERT INTO Produkty (Nazwa, Cena)
VALUES ('Nowy produkt', 199.99);
```

### ✏️ UPDATE
```sql
UPDATE Produkty
SET Cena = 149.99
WHERE Id = 1;
```

### ❌ DELETE
```sql
DELETE FROM Produkty
WHERE Id = 1;
```

## 🔐 Parametryzacja i dostęp do bazy danych w C#
```csharp
using System.Data.SqlClient;

string connectionString = "Server=.;Database=Magazyn;Trusted_Connection=True;";
using var connection = new SqlConnection(connectionString);
connection.Open();

string sql = "SELECT Name, Price FROM Produkty WHERE Price > @min";
using var cmd = new SqlCommand(sql, connection);
cmd.Parameters.AddWithValue("@min", 100);

using var reader = cmd.ExecuteReader();
while (reader.Read())
{
    string name = reader.GetString(0);
    decimal price = reader.GetDecimal(1);
    Console.WriteLine($"{name} - {price} zł");
}
```

📌 Kluczowe komponenty:
- `SqlConnection` – połączenie z bazą
- `SqlCommand` – zapytanie SQL
- `SqlDataReader` – strumieniowe odczytanie wyników

🛡️ **Zawsze używaj `using`** – zapewnia automatyczne zamknięcie połączenia i zasobów.

---
