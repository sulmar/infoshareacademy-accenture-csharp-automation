# 🧪 Ćwiczenie – system magazynowy

---
## 📝 Opis:
W zakładzie przemysłowym funkcjonuje **linia produkcyjna**, która realizuje zlecenia produkcyjne. Gotowe produkty trafiają do **magazynu**, z którego mogą zostać odebrane przez dział logistyki.

W zakładzie pracują maszyny takie jak **mieszalniki**, **sprężarki powietrza** i **sprężarki olejowe**, które działają w ustalonej kolejności. Każdy produkt przechodzi przez wszystkie maszyny, zanim trafi do magazynu.


## 🧠 Twoje zadanie:

Zaimplementuj klasy i strukturę danych symulującą proces produkcji i składowania.

Każda z klas powinna implementować metodę `Produce`, zwracającą tekst w formacie:
```
ITEM-001 mixed by Mixer-1
```

### Wymagania
- **1. Dodawanie maszyn do linii produkcyjnej**
Maszyny (Mixer, AirCompressor, OilCompressor) powinny być dodawane do listy reprezentującej linię produkcyjną w kolejności, w jakiej mają przetwarzać produkty.

- **2. Dodawanie zleceń produkcyjnych**
Zlecenia identyfikowane kodem (np. ITEM-001) należy dodawać do kolejki FIFO, zachowując kolejność zgłoszeń.

- **3. Przetwarzanie zlecenia**
- Pobierz pierwsze zlecenie z kolejki.
- Przeprowadź produkt przez wszystkie maszyny w linii – każda maszyna wykonuje operację `Produce(...)`.
- Produkt gotowy dodaj na stos magazynowy

- **4. Załadunek produktu gotowego**
Zdejmij gotowy produkt z wierzchu stosu magazynowego i wypisz jego identyfikator – oznacza to przekazanie produktu do transportu.

## Dla chętnych

- **Jeśli magazyn osiągnie maksymalną pojemność (5 produktów):**
	- Kolejne produkty nie zostaną dodane,
	- Wypisywany jest komunikat ostrzegawczy.
- Produkcja nadal kontynuuje przetwarzanie zleceń, ale pomija ich składowanie, gdy brak miejsca.

## Czas: 45 min.
