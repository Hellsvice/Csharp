# Személynyilvántartó

C#-os WPF gyakorlóprojekt, amelyben személyeket lehet listázni, hozzáadni, módosítani és törölni. A program nevet és életkort tárol. A felület adatkötéssel jeleníti meg a rekordokat, az adatbázis-műveleteket pedig a `PersonRepository` végzi Entity Framework Core segítségével.

## Futtatás

Windows, .NET 8 SDK és SQL Server Express LocalDB szükséges. A projekt mappájában futtasd:

```powershell
dotnet run --project .\Hazi5WPF_CRUD.csproj
```

A program indításkor létrehozza a `PersonDB2` adatbázist a helyi `MSSQLLocalDB` példányon, ha még nincs ilyen adatbázis. Üres adatbázis esetén három mintaadattal tölti fel a listát.

Programozástanári segítséggel készült gyakorlóprojekt.
