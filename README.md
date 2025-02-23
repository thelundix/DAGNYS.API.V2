# Mormor Dagnys Bageri API
Detta är startprojektet för hantering av beställningar, produkter och kunder för Mormor Dagnys Bageri.
Projektet är konfigurerat för att använda Sqlite som databas.

## Komma igång
Kör följande kommando i terminalen:

```sh
dotnet ef migrations add InitialSqlite -o Data/Migrations
```

Nästa steg är att köra migreringen så kör följande kommando i samma terminalfönster:

```sh
dotnet ef database update
```

## Dummy data
Det finns testdata som vi kan fylla databasen med. Data som finns just nu är leverantörer och adresser.

## Starta applikationen
Starta applikationen med kommandot:

```sh
dotnet run
```

Då körs seed-skriptet och databasen fylls med testdata.

