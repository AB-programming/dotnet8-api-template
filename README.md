# .NET8 API Template

This repository is a simple initialization template based on the .NET 8 API, with common functionalities built-in.

## Built-in functions 📦

- User System(Authentication, Permission), Authentication uses JWT

## Template Usage Instructions 🚀

### Required Environment

- .NET8(Or a version greater than 8)
- SQL Server 2019
- dotnet-ef

### Usage steps

Firstly, Install the template locally

```powershell
dotnet new install .
```

Execute the above command to install the template locally. The template name is "dotnet8-api-template".

Secondly, execute the following command to initialize the project using template a.

```powershell
dotnet new dotnet8-api-template -n YourProjectName --DbCatalog=YourDbCatalog --DbUserId=YourDbUserId --DbPassword=YourDbPassword
```

The parameter is explained as follows:
- YourProjectName: Specify your project name
- YourDbCatalog: Specify your SQL Server database name
- YourDbUserId: Specify your SQL Server username
- YourDbPassword: Specify your SQL Server password

Then, initialize the database.

You need to use dotnet-ef. If you don't have it, you can install it using the following command.

```powershell
dotnet tool install --global dotnet-ef
```

Initialize the database using the following command.

```powershell
dotnet ef migrations add Init
dotnet ef database update
```

Finally, it can be built or executed using the following commands.

```powershell
dotnet build
```

```powershell
dotnet run
```
