# Mormor Dagnys Bageri API
Detta är startprojektet för hantering av beställningar, produkter och kunder för Mormor Dagnys Bageri.
Projektet är konfigurerat för att använda Sqlite som databas för enkelhetens skull. Det finns även konfiguration för att kunna köra mot en MySql-databas, men då måste först en container startas för att kunna kommunicera med den.

Så jag kommer att använda Sqlite för detta projekt.

## Komma igång
Kör följande kommando i terminalen, det är viktigt att vi står i roten av projektet eshop.api:

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

