# ProjectBaseX
Será um projeto base para iniciar outros projetos, com uma arquitetura escalável e que não fique muito complexa.

[![Build status](https://danrrodrigues.visualstudio.com/ProjectBaseX/_apis/build/status/ProjectBaseX-Azure%20Web%20App%20for%20ASP.NET-CI)](https://danrrodrigues.visualstudio.com/ProjectBaseX/_build/latest?definitionId=1)


## Alguns conceitos e tecnologias utilizadas
* C# 
* .NET Core 2.1 
* EF Core
* DDD(Design Domain Drive)
* FluentValidation
* WebApi
* Visual Studio 2017






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

In Api

`Install-Package Swashbuckle.AspNetCore`


`Referências:`

https://medium.com/@renato.groffe/asp-net-core-2-0-autentica%C3%A7%C3%A3o-em-apis-utilizando-jwt-json-web-tokens-4b1871efd


http://www.eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/

