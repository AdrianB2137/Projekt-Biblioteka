# Projekt-Biblioteka

## Cel projektu

Aplikacja Windows Forms do zarządzania książkami i autorami w bazie danych PostgreSQL. Umożliwia:
- dodawanie, edytowanie i usuwanie książek oraz autorów
- oznaczanie ich jako dostępne/niedostępne

## Technologie

- .NET 8 (Windows Forms)
- C#
- PostgreSQL (przez pgAdmin 4)
- Entity Framework Core (code-first)
- Visual Studio 2022+

## Funkcjonalności

### Książki (Tabela: Ksiazki)
- Dodaj książkę (tytuł, autor, data wydania)
- Edytuj istniejącą książkę
- Usuń książkę
- Zmień dostępność książki

### Autorzy (Tabela: Autorzy)
- Dodaj autora
- Edytuj autora
- Usuń autora (jeśli nie przypisany do książek)
- Lista autorów z DataGridView

## Wymagane pakiety NuGet

Instalowane w Visual Studio:

```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Npgsql.EntityFrameworkCore.PostgreSQL
Microsoft.Extensions.Configuration.Json
```

## Struktura bazy danych (PostgreSQL)

### Tabela: Autorzy
| Kolumna     | Typ danych |
|-------------|-------------|
| Id          | int (PK)    |
| ImieNazwisko| text        |

### Tabela: Ksiazki
| Kolumna      | Typ danych |
|--------------|-------------|
| Id           | int (PK)    |
| Tytul        | text        |
| DataWydania  | date        |
| Dostepna     | boolean     |
| AutorId      | int (FK)    |

Relacja: `Ksiazki.AutorId -> Autorzy.Id`

## Jak uruchomić projekt

1. Utwórz bazę danych PostgreSQL (np. `biblioteka`)
2. Zmień dane połączenia w `appsettings.json`:
3. Uruchom projekt w Visual Studio 
4. Gotowe

## Autor
Imię i nazwisko: Adrian Boroń
Numer Indeksu: 131408

