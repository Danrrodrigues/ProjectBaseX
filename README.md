# ProjectBaseX
Será um projeto base para iniciar outros projetos, com um arquitetura escalável e que não fique extremamente complexa.

## Alguns conceitos e tecnologias ultilizadas
* C# 
* .NET Core 2.1 
* EF Core
* DDD(Design Domain Drive)
* Fluent
* WebApi






## Comandos úteis utilizados ao longo do projeto

In project Domain

`Install-Package FluentValidation.AspNetCore`

In project Infra.Data

`Install-Package Microsoft.EntityFrameworkCore.Design`

`Install-Package Microsoft.EntityFrameworkCore.Tools`

`Install-Package MySqlConnector`

`Install-Package Pomelo.EntityFrameworkCore.MySql`


`dotnet ef migrations add InitialCreate`

`Update-Database -verbose`

`Add-Migration Custom`

`Update-Database -verbose`

