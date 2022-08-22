# Revise_NETCORE_EFCORE_SQLSERVER
This is created for revision of core concepts of .NET 6.0 based API creation and doing CRUD operations on SQL Server docker instances through LINQ as well as Stored Procedures

Step 1 - (Getting SQL Server image and spinning up a container)
Refer - https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&pivots=cs1-cmd

Step 2 - Create new API project + Modify appsettings.json to have connection strings

Step 3 - Add EFCORE.Tools, EFCORE.Design, EFCORE.SqlServer dependencies through Nuget, so that they get added as Package reference in csproj

Step 4 - Add model classes, readmodel classes, the main CONTEXT class which extends DbContext

Step 5 - In Program.cs, add builder services to add context class and force it to use SqlServer mode with connection string read from builder.Configuration. Add scoped services if required

Step 6 - dotnet ef migrations add InitialMigration -> In Up method, remove creation logic for readmodel dto to avoid unnecessary table creation

Step 7 - dotnet ef database update -> DB updated

Step 8 - Follow controller code to understand how LINQ and SP is being invoked.

Happy Coding!
