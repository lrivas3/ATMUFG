

![Logo](./bank.png)

# UFG Bank ATM

ATM Web Application built with ASP.NET Core and MVC pattern

## Integrantes

| Nombre                        | Carnet                |
| --------                      | -------               |
| Emerson Leonardo Rivas Mejía  | RM101421              |
| Glendy Lisbeth Argueta Rivera | AR100621              |
| Nelson Ivan Colorado Lainez   | CL100511              |
| Celso Abraham García Cáceres  | GC100221              |
| Caleb Isai Hernandez Ramos    | HR100621              |
| Brett Alexander Carcamo Paz   | CP100320              |
| Agreguen su nombre            |   Agreguen su Carnet  |
| Agreguen su nombre            |   Agreguen su Carnet  |


## Tech Stack

**Framework:** .NET 6

**ORM:** EntityFramework

**Database:** Microsoft SQL Server

**Migration tool:** dotnet-ef

**Identity provider:** Microsoft.AspNetCore.Identity.EntityFrameworkCore

## Requisitos

- ### Framework

Debes tener instalado el framework .NET 6.0. Si aún no lo has instalado, puedes hacerlo con el comando en windows:

```bash
winget install Microsoft.DotNet.SDK.6
```
Si ya tienes otra version del framework instalada y quieres cambiar de version puedes hacerlo con el comando:
    
```bash
dotnet new globaljson --sdk-version <version a la que quieres cambiar (sin los simbolos de <>)> --force
```
opcionalmente puedes añadir la flag --force en caso de que ya tengas un archivo global.json creado y te de ese error.

- ### Base de datos

También necesitarás tener instalado el motor de base de datos SQL Server. Puedes descargarlo desde este [enlace](https://info.microsoft.com/ww-landing-sql-server-2022.html?culture=en-us&country=US).
 O si usas Docker puedes usar este docker-compose file que ya tienen las credenciales usadas en el proyecto:

```bash

version: '3.3'
services:
  sql-server:
    container_name: atm-sql-server
    image: mcr.microsoft.com/mssql/server:2022-latest
    restart: unless-stopped
    ports:
      - 1433:1433
    environment:
      - ACCEPT_EULA=Y
      - MSSQL_SA_PASSWORD=sqlDevops12345#2
      - MSSQL_PID=Developer
    volumes:
      - ./backups:/var/opt/mssql/backups/

```

- ### Herramient de migración

Para restaurar las tablas de la base de datos del proyecto necesitarás dotnet-ef

Si no tienes las herramienta puedes instalarla en windows con el siguiente comando:

```bash
dotnet tool install --global --version 7 dotnet-ef
```


## Installation

Primero clona el proyecto y luego ejecuta:

```bash
  dotnet restore
```

Para instalar las dependencias necesarias.


## Database Connection

Para ejecutar este proyecto, necesitarás configurar el string de conexión en el archivo `appsettings.json`

actualiza los valores de:

```bash
    "DefaultConnection": "Data Source=localhost; UID=sa; Password=sqlDevops12345#2; Database=ATM;"
```

de acuerdo a tu configuración o utiliza los mismos valores de tu instancia de SQL Server.

## Database Migration

Usa la herramienta de migración para crear la base de datos:

```bash
  dotnet ef database update
```
Si necesitas crear una nueva migracion, puedes hacerlo con el comando:

```bash
  dotnet ef migrations add NombreDeMigracion
```


## Run Locally

Para correr el proyecto localmente, ejecuta el siguiente comando:

```bash
  dotnet run
```
estando en la carpeta del proyecto que contiene el achivo `BankAtmMVC.csproj`

o especificando la flag --project `seguido de la ruta de la carpeta que contiene el archivo BankAtmMVC.csproj`

## Feedback

Si tienes algún comentario, por favor contáctanos en este [enlace](https://www.youtube.com/watch?v=riT4nl0T8_M).

