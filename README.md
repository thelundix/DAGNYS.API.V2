# Mormor Dagnys Bageri API
Inlämningsuppgift Del 2 C# Fortsättning , befintligt API från Inlämningsuppgift Del 1 C# byggs på med hantering av beställningar, produkter och
kunder.

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

## Dummy data Json
Det finns testdata som vi kan fylla databasen med. Data som finns just nu är customers, orders/orderItems, products tillhörande Inlämningsuppgift Del 2 C# Fortsättning, samt testdata från Inlämningsuppgift Del 1 C# följande suppliers, rawmaterails, supplierrawmaterials.

## Starta applikationen
Starta applikationen med kommandot:

```sh
dotnet run
```

Då körs seed-skriptet och databasen fylls med testdata.

