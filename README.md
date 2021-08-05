# CS-NET-Core-Case

Een .NET Core 5.0 Web API met SQLite database, geschreven in C# met Swagger endpoint documentatie.

## Instructies

-Microsoft Visual Studio 2019

Het project wordt opgestart door hem te builden in Visual Studio d.m.v. IISExpress, dan wordt een browser geopend met daarop https://localhost:44396/index.html. Deze pagina geeft dan de Swagger implementatie weer.

## Reflectie

Het is jammer dat ik ondanks kennis met databases in Laravel en Angular nog steeds moeite heb met de daadwerkelijke connectie leggen tussen de geschreven code en de database. Ook omdat dit de eerste keer is dat ik Swagger gebruik, had ik moeite met begrijpen waar het mis ging toen ik 404 foutmeldingen kreeg. 

Ik ben erg tevreden over hoe ik uiteindelijk de CRUD endpoints werkende heb gekregen door erachter te komen dat er iets mis was met UseEndpoints in de Startup.Configure. Daar moest ik gebruik maken van de MapDefaultControllerRoute. Het duurde bijna een hele dag voordat ik de 404 error die ik kreeg kon verklaren.

## Versions

-.NET 5.0 (SDK Version: 5.0.302)

Package References:

-Microsoft.EntityFrameworkCore.Sqlite: 5.0.8

-Microsoft.EntityFrameworkCore.Tools: 5.0.8

-Swashbuckle.AspNetCore: 6.1.5
