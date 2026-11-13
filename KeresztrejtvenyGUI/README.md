# Keresztrejtvény-szerkesztő

C#-os WPF alkalmazás, amelyben 6–15 soros és 6–15 oszlopos rácsot lehet létrehozni. Egy cellába egy karakter írható. Az üres cellát a `-` jelöli, dupla kattintással pedig a `-` és a `#` jelölés között válthatsz.

## Futtatás

Windows és .NET 8 SDK szükséges. A projekt mappájában futtasd:

```powershell
dotnet run --project .\KeresztrejtvenyGUI.csproj
```

Válaszd ki a sorok és oszlopok számát, majd kattints a **Keresztrejtvény létrehozása** gombra. A mentésnél kiválasztott sorszám adja a fájl nevét. Például a 3-as sorszám a `kr3.txt` fájlba menti a rácsot az aktuális munkamappában.

Programozástanári segítséggel készült gyakorlóprojekt.
