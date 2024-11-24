# EmployeeManagement

# Project Struccture:

EmployeeManagement/
├── src/
│   ├── EmployeeManagement.API/          # REST API Presentation Layer (Controllers, Models, etc.)
│   ├── EmployeeManagement.Application/  # Application Layer (DTOs, Services, etc.)
│   ├── EmployeeManagement.Core/         # Domain Layer (Entities)
│   └── EmployeeManagement.Infrastructure/ # Infrastructure Layer (Data, Repositories, etc.)
└── tests/
    ├── EmployeeManagement.UnitTests/
    └── EmployeeManagement.IntegrationTests/


Request HTTP → API Controller 
                  ↓
             Application Service
                  ↓
             Repository (Infrastructure)
                  ↓
             Database

Technology Stack

Entity Framework Core: ORM for database operations
ASP.NET Core OpenAPI: API documentation 
Dependency Injection: Built-in DI container in .NET
AutoMapper: Mapper between DTOs and Entities

# Pre-requisitos
.NET 8.0
SQL Server
Visual Studio 2022 o VS Code

# Configuración Inicial

- Clone the repository:

git clone https://git.number8.com/erick.Ramirez/net-assessment.git
cd employee-management

- Restore dependencies:

dotnet restore

- Run the application:

dotnet run

# Technology Stack

ASP.NET Core 8
Entity Framework Core
SQL Server
AutoMapper

# Features

CRUD for employees
Department management
REST API