# Task-Management-App-
Task management app is a starter app implementing Services Repository and Unit of Work Pattern and Devexpress front end framework.


## Getting Started

### Project Structure

- TaskManagementApp.Repository - defined as the data access layer of the project. This will interact directly interact with the model abstracting basic CRUD operations.
- TaskManagementApp.Service - responsible for encapsulating repository activities. This will serve as the transformation layer of the queries from repository.
- TaskManagementApp.Model - [POCO](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes) contains the plain old class objects (POCO)
- TaskManagementApp - contains the controller and view part of the web application.

## Prerequisites
This are the required nuget packages needed to implement the above mentioned architecture.

### TaskManagementApp

- [Unity](https://www.nuget.org/packages/Unity/)
- [Unity Container](https://www.nuget.org/packages/Unity.Container/)

### TaskManagementApp.Model

- [Entity framework](https://www.nuget.org/packages/EntityFramework/)


### TaskMangementApp.Repository 

- [Trackable Entities](https://www.nuget.org/packages/TrackableEntities.EF.6/)

### TaskManagementApp.Services

- [Trackable Entities](https://www.nuget.org/packages/TrackableEntities.EF.6/)



## Technology Stack 

- [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc) - is a modern web framework for building web applications with .Net Framework.
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2017) - relational database used in building this web app.
- [Entity Framework](https://docs.microsoft.com/en-us/ef/) - object Relational Mapper that will generate the POCO or the model part of the web application.
- [Devexpress MVC](https://demos.devexpress.com/mvc/) - .Net extension that takes care of the view part of the MVC architecture.

