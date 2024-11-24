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

# Pre-requisitos
.NET 8.0
SQL Server
Visual Studio 2022 o VS Code

# Configuración Inicial

- Clonar el repositorio:

git clone https://git.number8.com/erick.Ramirez/net-assessment.git
cd employee-management

- Restaurar las dependencias:

dotnet restore

- Actualizar la base de datos:

cd src/EmployeeManagement.API
dotnet ef database update

- Ejecutar la aplicación:

dotnet run

# Tecnologías Utilizadas

ASP.NET Core 7/8
Entity Framework Core
SQL Server
AutoMapper
xUnit (para pruebas)

# Características

CRUD completo de empleados
Gestión de departamentos
API REST
Autenticación mediante API Key