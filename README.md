# Platform Service

- make project `dotnet new webapi -n PlatformService`
- add ignore file `dotnet new gitignore`
- add packages
  - AutoMapper: `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`
  - Entity Framework: `dotnet add package Microsoft.EntityFrameworkCore`, `dotnet add package Microsoft.EntityFrameworkCore.Design`, `dotnet add package Microsoft.EntityFrameworkCore.InMemory`, `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

## Dockerize

- build image: `docker build -t mohsen1299/platformservice .`
- run image: `docker run -p 8080:80 -d mohsen1299/platformservice`
- push image to docker hub: `docker push mohsen1299/platformservice`

## Reference

- base on video [.NET Microservices – Full Course](https://youtu.be/DgVjEo3OGBI) by [Les Jackson](https://www.youtube.com/c/binarythistle)
