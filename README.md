# CS-NET-Core-Case

Een .NET Core 5.0 Web API met SQLite database, geschreven in C# met Swagger endpoint documentatie.

## Instructies

- Microsoft Visual Studio 2019

Het project wordt opgestart door hem te builden in Visual Studio d.m.v. IISExpress, dan wordt een browser geopend met daarop https://localhost:44396/index.html. Deze pagina geeft dan de Swagger implementatie weer.

## Reflectie

Het is jammer dat ik ondanks kennis met databases in Laravel en Angular nog steeds moeite heb met de daadwerkelijke connectie leggen tussen de geschreven code en de database. Ook omdat dit de eerste keer is dat ik Swagger gebruik, had ik moeite met begrijpen waar het mis ging toen ik 404 foutmeldingen kreeg. 

Ik ben erg tevreden over hoe ik uiteindelijk de CRUD endpoints werkende heb gekregen door erachter te komen dat er iets mis was met UseEndpoints in de Startup.Configure. Daar moest ik gebruik maken van de MapDefaultControllerRoute. Het duurde bijna een hele dag voordat ik de 404 error die ik kreeg kon verklaren.

Bij het maken van deel 2 van de opdracht had ik veel moeite met dynamische manieren vinden om te sorteren en filteren. Voor het sorteren kon ik geen andere oplossing vinden dan een vrij grote switch case... Deze heb ik daarom ook niet toegevoegd aan het project. Voor het filteren heb ik het wel voor elkaar gekregen om geen grote switch case of vele if-statements te gebruiken, maar er zit nog steeds een stuk in waar ik niet zo tevreden mee ben. Namelijk dat ik in plaats van if-statements gewoon gebruik maak van de || operator om alle verschillende eigenschappen te benoemen (Repositories/AddressRepository.cs line 55 en 57). Ik heb een poging gedaan om dictionaries te gebruiken en dan door de keys te loopen, maar kwam daar niet helemaal uit.

Deel 3 van de opdracht heb ik bekeken, maar ben ik niet aan toegekomen door het bovenstaande probleem.

## Versions

- .NET 5.0 (SDK Version: 5.0.302)

Package References:
- AutoMapper: 10.1.1
- AutoMapper.Extensions.Microsoft.DependencyInjection: 8.1.1
- DynamicExpressions.NET: 1.0.0
- Microsoft.EntityFrameworkCore.Sqlite: 5.0.8
- Microsoft.EntityFrameworkCore.Tools: 5.0.8
- Swashbuckle.AspNetCore: 6.1.5
- System.IO: 4.3.0
