# Saját verem és zárójel-ellenőrző

A `CustomStack<T>` tömbön tárolja az elemeket, és saját kivételt jelez üres vagy megtelt verem esetén. A konzolos példa ezzel ellenőrzi, hogy a `()`, `[]` és `{}` zárójelek párosítása és sorrendje helyes-e.

## Futtatás

Windows, Visual Studio és a .NET Framework 4.7.2 fejlesztőcsomag szükséges. Nyiss egy **Developer PowerShell for Visual Studio** ablakot a projekt mappájában, majd futtasd:

```powershell
msbuild .\2024_07_05.csproj
& '.\bin\Debug\2024_07_05.exe'
```

A program az aktuális munkamappában található `Program.cs` fájlt olvassa. Szövegként vizsgálja a zárójeleket, ezért a megjegyzésekben és a sztringekben lévő zárójeleket is figyelembe veszi.

Programozástanári segítséggel készült gyakorlóprojekt.
