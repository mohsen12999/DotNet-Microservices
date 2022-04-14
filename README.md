# Platform Service

- make project `dotnet new webapi -n PlatformService`
- add ignore file `dotnet new gitignore`
- add packages
  - AutoMapper: `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`
  - Entity Framework: `dotnet add package Microsoft.EntityFrameworkCore`, `dotnet add package Microsoft.EntityFrameworkCore.Design`, `dotnet add package Microsoft.EntityFrameworkCore.InMemory`, `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
