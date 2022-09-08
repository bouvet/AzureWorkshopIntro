# AzureWorkshopIntro
 
## NuGet Packages
Microsoft.AspNetCore.Authentication.JwtBearer <br>
Microsoft.Azure.Services.AppAuthentication <br>
Microsoft.EntityFrameworkCore <br>
Microsoft.EntityFrameworkCore.Design <br>
Microsoft.EntityFrameworkCore.SqlServer <br>
Microsoft.Identity.Web <br>
Swashbuckle.AspNetCore <br>
 
## Commands
dotnet tool install dotnet-ef -g <br>
dotnet ef migrations add [name] <br>
dotnet ef database update <br>
dotnet ef migrations remove <br>


## Tasks

### Del 1: Database og migrering
1. Lag en database (bruk felles server)
2. Lag et nytt Prosjekt i VS (ASP.NET Core Web Api)
3. Lag databasemodeller som klasser
4. Lag en databasecontext
5. Sett opp dbcontext i Program.cs
6. Gjør en migrering mot egen database

### Del 2: Endepunkter
1. Lag et endepunkt for å legge til en ny Speaker
2. Lag et endepunkt for å legge til en ny Workshop
3. Lag et endepunkt for å hente ut alle Workshops

### Del 3: Authentication og Authorization
