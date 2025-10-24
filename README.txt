ContractMonthlyClaimSystem (.NET 8) - POE Part 2 scaffold
======================================================

This is a minimal ASP.NET Core MVC project scaffold (source only) created to implement
Part 2 of the Contract Monthly Claim System (CMCS) POE.

What it contains:
- Models/Claim.cs
- Data/ApplicationDbContext.cs
- Controllers/ClaimsController.cs
- Views/Claims: Create.cshtml, MyClaims.cshtml, Review.cshtml
- Basic Program.cs and appsettings.json
- wwwroot/uploads folder (empty) for uploaded documents
- A lightweight layout and shared view imports to run the app

How to use:
1. Extract the ZIP and open the folder in Visual Studio 2022 (or VS Code + dotnet 8 SDK).
2. Run `dotnet restore` in the project folder.
3. Create the database:
   - Install EF tools if needed: `dotnet tool install --global dotnet-ef`
   - Add migration: `dotnet ef migrations add InitialCreate`
   - Update DB: `dotnet ef database update`
4. Run the app with Visual Studio or `dotnet run`.

Notes:
- The default connection string uses localdb. Change appsettings.json if you prefer SQL Server.
- In production you'd store uploads outside wwwroot and secure review endpoints with authorization.

