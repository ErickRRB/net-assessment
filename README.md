# EmployeeManagement

# Project Struccture:
```
EmployeeManagement/
├── src/
│   ├── EmployeeManagement.API/          # REST API Presentation Layer (Controllers, Models, etc.)
│   ├── EmployeeManagement.Application/  # Application Layer (DTOs, Services, etc.)
│   ├── EmployeeManagement.Core/         # Domain Layer (Entities)
│   └── EmployeeManagement.Infrastructure/ # Infrastructure Layer (Data, Repositories, etc.)
└── tests/
    ├── EmployeeManagement.UnitTests/
    └── EmployeeManagement.IntegrationTests/
```
```
Request HTTP -> API Controller -> Application Service -> Repository -> Database
```
# Technology Stack

Entity Framework Core: ORM for database operations
ASP.NET Core 8: Backend framework
SQL Server: Database
AutoMapper: Object-Object mapping
Swagger: API documentation


# Pre-requisites
- .NET 8.0
- SQL Server
- Visual Studio 2022 o VS Code

# Initial Configuration

- Clone the repository:

git clone https://git.number8.com/erick.Ramirez/net-assessment.git

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

# Authentication

The API uses API Key authentication. All requests must include:

Header name: X-API-Key
Value: n8-assessment-api-key-erick-ramirez

Example using curl:
curl -H "X-API-Key: assessment-api-key-erick-ramirez" https://localhost:xxxx/api/employees where xxxx is the port number

This application is designed for local development and testing purposes as part of a technical assessment. It runs on localhost and includes all necessary configurations for local testing and evaluation.
